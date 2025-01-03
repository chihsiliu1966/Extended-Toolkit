﻿#region MIT License
/*
 * MIT License
 *
 * Copyright (c) 2017 - 2024 Krypton Suite
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */
#endregion

#pragma warning disable CS0414
namespace Krypton.Toolkit.Suite.Extended.Messagebox
{
    /// <summary>Allows the creation of a <see cref="KryptonMessageBoxExtended"/> through the designer.</summary>
    /// <seealso cref="Component" />
    [ToolboxBitmap(typeof(KryptonMessageBox), "ToolboxBitmaps.KryptonMessageBox.bmp"),
     DefaultEvent("ShowMessageBox"), DefaultProperty("MessageBoxContentText"),
     Description("Allows the creation of a KryptonMessageBoxExtended through the designer."),
     ToolboxItem(true)]
    //, Designer(typeof(KryptonMessageBoxConfiguratorDesigner))]
    internal class KryptonMessageBoxManager : Component
    {
        #region Fields

        private bool _showCtrlCopy, _showOptionalCheckBox, _isOptionalCheckBoxChecked, _showHelpButton, _showOptionalLinkLabel, _openInExplorer;

        private CheckState _optionalCheckBoxCheckState;

        private ExtendedMessageBoxButtons _buttons;

        private ExtendedKryptonMessageBoxIcon _icon;

        private KryptonMessageBoxDefaultButton _defaultButton;

        private ExtendedKryptonMessageBoxMessageContainerType _messageContainerType;

        private MessageBoxOptions _options;

        private Font _messageBoxTypeface;

        private Image? _customImageIcon;

        private string _text, _captionText, _helpFilePath, _optionalCheckBoxText, _optionalLinkLabelText, _optionalLinkLabelDestination, _applicationPath, _linkDestination;

        private object? _parameters;

        private HelpNavigator _helpNavigator;

        private IWin32Window? _owner;

        private LinkArea _linkArea;

        #endregion

        #region Properties
        /// <summary>Gets or sets a value indicating whether [show control copy].</summary>
        /// <value><c>true</c> if [show control copy]; otherwise, <c>false</c>.</value>
        [DefaultValue(false), Description(@"Show control, copy shortcut. (Ctrl + C)")]
        public bool ShowCtrlCopy { get => _showCtrlCopy; set => _showCtrlCopy = value; }

        /*
        /// <summary>Gets or sets a value indicating whether [show optional CheckBox].</summary>
        /// <value><c>true</c> if [show optional CheckBox]; otherwise, <c>false</c>.</value>
        [DefaultValue(false), Description(@"Displays the optional check box.")]
        public bool ShowOptionalCheckBox { get => _showOptionalCheckBox; set => _showOptionalCheckBox = value; }

        /// <summary>Gets or sets a value indicating whether this instance is optional CheckBox checked.</summary>
        /// <value><c>true</c> if this instance is optional CheckBox checked; otherwise, <c>false</c>.</value>
        [DefaultValue(false), Description(@"Sets whether the optional check box is checked or not.")]
        public bool IsOptionalCheckBoxChecked { get => _isOptionalCheckBoxChecked; set => _isOptionalCheckBoxChecked = value; }
        */

        [DefaultValue(false), Description(@"")]
        public bool ShowHelpButton { get => _showHelpButton; set => _showHelpButton = value; }

        [DefaultValue(false), Description(@"")]
        public bool OpenInExplorer { get => _openInExplorer; set => _openInExplorer = value; }

        /*
        [DefaultValue(false), Description(@"")]
        public bool ShowOptionalLinkLabel { get => _showOptionalLinkLabel; set => _showOptionalLinkLabel = value; }

        /// <summary>Gets or sets the state of the optional CheckBox check.</summary>
        /// <value>The state of the optional CheckBox check.</value>
        [DefaultValue(typeof(CheckState), "CheckState.Unchecked"), Description(@"Sets the optional check box check state.")]
        public CheckState OptionalCheckBoxCheckState { get => _optionalCheckBoxCheckState; set => _optionalCheckBoxCheckState = value; }
        */

        /// <summary>Gets or sets the message box icon.</summary>
        /// <value>The message box icon.</value>
        [DefaultValue(typeof(ExtendedKryptonMessageBoxIcon), "ExtendedKryptonMessageBoxIcon.NONE"), Description(@"Set the message box icon.")]
        public ExtendedKryptonMessageBoxIcon MessageBoxIcon { get => _icon; set => _icon = value; }

        /// <summary>Gets or sets the message box buttons.</summary>
        /// <value>The message box buttons.</value>
        [DefaultValue(typeof(ExtendedMessageBoxButtons), "ExtendedMessageBoxButtons.OK"), Description(@"Sets the message button layout.")]
        public ExtendedMessageBoxButtons MessageBoxButtons { get => _buttons; set => _buttons = value; }

        /// <summary>Gets or sets the default button.</summary>
        /// <value>The default button.</value>
        [DefaultValue(typeof(KryptonMessageBoxDefaultButton), "KryptonMessageBoxDefaultButton.Button1"), Description(@"The default selected message box button.")]
        public KryptonMessageBoxDefaultButton DefaultButton { get => _defaultButton; set => _defaultButton = value; }

        [DefaultValue(typeof(ExtendedKryptonMessageBoxMessageContainerType), "ExtendedKryptonMessageBoxMessageContainerType.Normal"), Description(@"")]
        public ExtendedKryptonMessageBoxMessageContainerType MessageContainerType { get => _messageContainerType; set => _messageContainerType = value; }

        /// <summary>Gets or sets the options.</summary>
        /// <value>The options.</value>
        [DefaultValue(typeof(MessageBoxOptions), "MessageBoxOptions.DefaultDesktopOnly"), Description(@"Specifies extra message box options.")]
        public MessageBoxOptions Options { get => _options; set => _options = value; }

        /// <summary>Gets or sets the message box typeface.</summary>
        /// <value>The message box typeface.</value>
        [DefaultValue(typeof(Font), "Segoe UI, 8.25F"), Description(@"Specifies the font on all text surfaces.Specifies")]
        public Font MessageBoxTypeface { get => _messageBoxTypeface; set => _messageBoxTypeface = value; }

        /// <summary>Gets or sets the application path.</summary>
        /// <value>The application path.</value>
        [DefaultValue(@""), Description(@"The application path.")]
        public string ApplicationPath { get => _applicationPath; set => _applicationPath = value; }

        [DefaultValue(@""), Description(@"")]
        public string LinkDestination { get => _linkDestination; set => _linkDestination = value; }

        /// <summary>Gets or sets the custom image icon.</summary>
        /// <value>The custom image icon.</value>
        [DefaultValue(null), Description(@"Specifies a custom message box icon. Note, you'll need to set the MessageBoxIcon to 'CUSTOM' for this to work.")]
        public Image? CustomImageIcon { get => _customImageIcon; set => _customImageIcon = value; }

        /// <summary>Gets or sets the text.</summary>
        /// <value>The text.</value>
        [DefaultValue(null), Description(@"Specifies the message box content text.")]
        public string Text { get => _text; set => _text = value; }

        /// <summary>Gets or sets the caption text.</summary>
        /// <value>The caption text.</value>
        [DefaultValue(null), Description(@"Specifies the message box window title text.")]
        public string CaptionText { get => _captionText; set => _captionText = value; }

        /// <summary>Gets or sets the help file path.</summary>
        /// <value>The help file path.</value>
        [DefaultValue(null), Description(@"The path and name of the Help file to display when the user clicks the Help button.")]
        public string HelpFilePath { get => _helpFilePath; set => _helpFilePath = value; }

        /// <summary>Gets or sets the optional CheckBox text.</summary>
        /// <value>The optional CheckBox text.</value>
        [DefaultValue(null), Description(@"Specifies the message box optional check box text.")]
        public string OptionalCheckBoxText { get => _optionalCheckBoxText; set => _optionalCheckBoxText = value; }

        /*
        [DefaultValue(null), Description(@"")]
        public string OptionalLinkLabelText { get => _optionalLinkLabelText; set => _optionalLinkLabelText = value; }

        [DefaultValue(null), Description(@"")]
        public string OptionalLinkLabelDestination { get => _optionalLinkLabelDestination; set => _optionalLinkLabelDestination = value; }
        */

        /// <summary>Gets or sets the parameters.</summary>
        /// <value>The parameters.</value>
        [DefaultValue(null), Description(@"The numeric ID of the Help topic to display when the user clicks the Help button.")]
        public object? Parameters { get => _parameters; set => _parameters = value; }

        /// <summary>Gets or sets the help navigator.</summary>
        /// <value>The help navigator.</value>
        [DefaultValue(0), Description(@"One of the System.Windows.Forms.HelpNavigator values.")]
        public HelpNavigator HelpNavigator { get => _helpNavigator; set => _helpNavigator = value; }

        /// <summary>Gets or sets the owner of the modal dialog box.</summary>
        /// <value>The owner of the modal dialog box.</value>
        [DefaultValue(null), Description(@"Owner of the modal dialog box.")]
        public IWin32Window? Owner { get => _owner; set => _owner = value; }

        public LinkArea LinkArea { get => _linkArea; set => _linkArea = value; }

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="KryptonMessageBoxManager" /> class.</summary>
        public KryptonMessageBoxManager()
        {
            _showCtrlCopy = false;

            _showOptionalCheckBox = false;

            _isOptionalCheckBoxChecked = false;

            _showHelpButton = false;

            _showOptionalLinkLabel = false;

            _openInExplorer = false;

            _optionalCheckBoxCheckState = CheckState.Unchecked;

            _buttons = ExtendedMessageBoxButtons.OK;

            _icon = ExtendedKryptonMessageBoxIcon.None;

            _defaultButton = KryptonMessageBoxDefaultButton.Button1;

            _messageContainerType = ExtendedKryptonMessageBoxMessageContainerType.Normal;

            _options = 0;

            _messageBoxTypeface = new Font(@"Segoe UI", 8.25F);

            _customImageIcon = null;

            _applicationPath = @"";

            _linkDestination = @"";

            _text = @"";

            _captionText = @"";

            _helpFilePath = @"";

            _optionalCheckBoxText = @"";

            _optionalLinkLabelDestination = @"";

            _optionalLinkLabelText = @"";

            _parameters = null;

            _helpNavigator = 0;

            _owner = null;

            _linkArea = new LinkArea();
        }

        /// <summary>Initializes a new instance of the <see cref="KryptonMessageBoxManagerTest" /> class.</summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="options">The options.</param>
        /// <param name="helpFilePath">The help file path.</param>
        /// <param name="navigator">The navigator.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="showCtrlCopy">The show control copy.</param>
        /// <param name="displayHelpButton"></param>
        /// <param name="messageBoxTypeface">The message box typeface.</param>
        /// <param name="customImageIcon">The custom image icon.</param>
        public KryptonMessageBoxManager(IWin32Window owner, string text, string caption,
                                                 ExtendedMessageBoxButtons buttons,
                                                 ExtendedKryptonMessageBoxIcon icon,
                                                 KryptonMessageBoxDefaultButton defaultButton,
                                                 MessageBoxOptions options,
                                                 string helpFilePath,
                                                 HelpNavigator navigator,
                                                 object? param, bool? showCtrlCopy,
                                                 bool? displayHelpButton,
                                                 Font messageBoxTypeface,
                                                 Image? customImageIcon,
                                                 string applicationPath,
                                                 string linkDestination,
                                                 bool openInExplorer,
                                                 ExtendedKryptonMessageBoxMessageContainerType? messageContainerType,
                                                 LinkArea linkArea)
        {
            Owner = owner;

            Text = text;

            CaptionText = caption;

            MessageBoxButtons = buttons;

            MessageBoxIcon = icon;

            DefaultButton = defaultButton;

            Options = options;

            HelpFilePath = helpFilePath;

            HelpNavigator = navigator;

            Parameters = param;

            MessageBoxTypeface = messageBoxTypeface;

            CustomImageIcon = customImageIcon;

            ShowCtrlCopy = showCtrlCopy ?? showCtrlCopy.GetValueOrDefault();

            ShowHelpButton = displayHelpButton ?? displayHelpButton.GetValueOrDefault();

            ApplicationPath = applicationPath;

            LinkDestination = linkDestination;

            OpenInExplorer = openInExplorer;

            MessageContainerType = messageContainerType ?? ExtendedKryptonMessageBoxMessageContainerType.Normal;

            LinkArea = linkArea;
        }

        #endregion

        #region Virtual

        /// <summary>Shows the message box.</summary>
        /// <returns></returns>
        public virtual DialogResult ShowMessageBox()
        {
            if (!ShowHelpButton)
            {

                return KryptonMessageBoxExtended.Show(Text, CaptionText, MessageBoxButtons,
                                                      MessageBoxIcon, DefaultButton,
                                                      Options, false,
                                                      ShowCtrlCopy, ApplicationPath);
            }
            else if (MessageBoxTypeface != null)
            {
                return KryptonMessageBoxExtended.Show(Text, CaptionText, MessageBoxButtons,
                                                      MessageBoxIcon, DefaultButton, Options,
                                                      ShowHelpButton, ShowCtrlCopy,
                                                      MessageBoxTypeface, CustomImageIcon);
            }
            else
            {
                return KryptonMessageBoxExtended.Show(Owner, Text, CaptionText,
                                                     MessageBoxButtons, MessageBoxIcon,
                                                     DefaultButton, Options,
                                                     HelpFilePath, HelpNavigator,
                                                     Parameters, ShowHelpButton,
                                                     ShowCtrlCopy, MessageBoxTypeface,
                                                     CustomImageIcon);
            }
        }

        #endregion

        #region Methods

        /// <summary>Displays the message box.</summary>
        /// <returns></returns>
        public DialogResult DisplayMessageBox()
        {
            if (!ShowHelpButton)
            {

                return KryptonMessageBoxExtended.Show(Text, CaptionText, MessageBoxButtons,
                                                      MessageBoxIcon, DefaultButton,
                                                      Options, false,
                                                      ShowCtrlCopy, ApplicationPath);
            }
            else if (MessageBoxTypeface != null)
            {
                return KryptonMessageBoxExtended.Show(Text, CaptionText, MessageBoxButtons,
                                                      MessageBoxIcon, DefaultButton, Options,
                                                      ShowHelpButton, ShowCtrlCopy,
                                                      MessageBoxTypeface, CustomImageIcon);
            }
            else
            {
                return KryptonMessageBoxExtended.Show(Owner, Text, CaptionText,
                                                     MessageBoxButtons, MessageBoxIcon,
                                                     DefaultButton, Options,
                                                     HelpFilePath, HelpNavigator,
                                                     Parameters, ShowHelpButton,
                                                     ShowCtrlCopy, MessageBoxTypeface,
                                                     CustomImageIcon);
            }
        }

        #endregion
    }
}