﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Messagebox
{
    /// <summary>
    /// Displays a message box that can contain text, buttons, and symbols that inform and instruct the user.
    /// Allows optional Font to be specified, if not then new Font(@"Microsoft Sans Serif", 8.25F) will be used
    /// </summary>
    [DesignerCategory("code"), ToolboxItem(false)]
    internal static class InternalKryptonMessageBoxExtended
    {
        #region Public
        /// <summary>
        /// Displays a message box in front+center of the application and with the specified text, caption, buttons, icon, default button, and options.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption" default="string.Empty">The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons" default="MessageBoxButtons.OK">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon" default="MessageBoxIcon.NONE">One of the System.Windows.Forms.MessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" default="MessageBoxDefaultButton.Button1">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" default="0">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="displayHelpButton" default="false">Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <param name="messageBoxButtonTypeface" default="null">The messagebox button typeface.</param>
        /// <param name="messageBoxTypeface" default="null">The messagebox typeface.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(string text,
                                        string caption = @"",
                                        ExtendedMessageBoxButtons buttons = ExtendedMessageBoxButtons.OK,
                                        ExtendedKryptonMessageBoxIcon icon = ExtendedKryptonMessageBoxIcon.NONE,
                                        MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions options = 0,
                                        bool displayHelpButton = false,
                                        bool? showCtrlCopy = null,
                                        Font? messageBoxButtonTypeface = null, Font? messageBoxTypeface = null)
            =>
                InternalShow(null, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                             icon, defaultButton,
                             null, null, null,
                             options, displayHelpButton ? new HelpInfo() : null, showCtrlCopy,
                             messageBoxButtonTypeface, messageBoxTypeface, null,
                             null, null, null, null, null, null,
                             null, null, null, null, null, null, null, null, null, null,
                             null, null, null, null, string.Empty,
                             null);


        /// <summary>
        /// Displays a message box in front+center of the application and with the specified text, caption, buttons, icon, default button, and options.
        /// </summary>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption" default="string.Empty">The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon" >One of the KryptonMessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" default="MessageBoxDefaultButton.Button1">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" default="0">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="displayHelpButton" default="false">Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(string text,
            string caption,
            ExtendedMessageBoxButtons buttons,
            ExtendedKryptonMessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
            MessageBoxOptions options = 0,
            bool displayHelpButton = false,
            bool? showCtrlCopy = null)
            =>
                InternalShow(null, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                             icon,
                             defaultButton, null, null, null,
                             options, displayHelpButton ? new HelpInfo() : null,
                             showCtrlCopy, null, null,
                             null, null, null, null, null,
                             null, null, null, null, null,
                             null, null, null, null,
                             null, null, null, null,
                             null, null, null, string.Empty,
                             null);

        /// <summary>
        /// Displays a message box in front+center of the specified object and with the specified text, caption, buttons, icon, default button, and options.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption" default="string.Empty">The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons" default="MessageBoxButtons.OK">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon" default="MessageBoxIcon.None">One of the System.Windows.Forms.MessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" default="MessageBoxDefaultButton.Button1">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" default="0">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="displayHelpButton" default="false">Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <param name="messageBoxButtonTypeface" default="null">The messagebox button typeface.</param>
        /// <param name="messageBoxTypeface" default="null">The messagebox typeface.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(IWin32Window owner, string text,
            string caption = @"",
            ExtendedMessageBoxButtons buttons = ExtendedMessageBoxButtons.OK,
            ExtendedKryptonMessageBoxIcon icon = ExtendedKryptonMessageBoxIcon.NONE,
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
            MessageBoxOptions options = 0,
            bool displayHelpButton = false,
            bool? showCtrlCopy = null,
            Font? messageBoxButtonTypeface = null,
            Font? messageBoxTypeface = null)
            =>
                InternalShow(owner, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                             icon, defaultButton, null,
                             null, null, options, displayHelpButton ? new HelpInfo() : null, showCtrlCopy,
                             messageBoxButtonTypeface, messageBoxTypeface, null,
                             null, null, null, null, null, null,
                             null, null, null, null, null, null, null, null, null, null,
                             null, null, null, null, string.Empty,
                             null);

        /// <summary>
        /// Displays a message box in front+center of the specified object and with the specified text, caption, buttons, icon, default button, and options.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon">One of the KryptonMessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" default="MessageBoxDefaultButton.Button1">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" default="0">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="displayHelpButton" default="false">Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(IWin32Window owner, string text,
            string caption,
            ExtendedMessageBoxButtons buttons,
            ExtendedKryptonMessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1,
            MessageBoxOptions options = 0,
            bool displayHelpButton = false,
            bool? showCtrlCopy = null)
            =>
                InternalShow(owner, text, caption, buttons, null,
                             string.Empty, string.Empty, string.Empty,
                             icon, defaultButton, null, null, null,
                             options, displayHelpButton ? new HelpInfo() : null,
                             showCtrlCopy, null, null,
                             null, null, null, null, null,
                             null, null, null, null, null,
                             null, null, null, null,
                             null, null, null,
                             null, null, null, null, string.Empty,
                             null);

        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons" >One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon" >One of the System.Windows.Forms.MessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" >One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" >One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help button.</param>
        /// <param name="navigator">One of the System.Windows.Forms.HelpNavigator values.</param>
        /// <param name="param">The numeric ID of the Help topic to display when the user clicks the Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <param name="messageBoxButtonTypeface" default="null">The messagebox button typeface.</param>
        /// <param name="messageBoxTypeface" default="null">The messagebox typeface.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(string text, string caption, ExtendedMessageBoxButtons buttons, ExtendedKryptonMessageBoxIcon icon,
                                        MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath,
                                        HelpNavigator navigator, object param, bool? showCtrlCopy = null,
                                        Font? messageBoxButtonTypeface = null, Font? messageBoxTypeface = null)
            => InternalShow(null, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                            icon, defaultButton, null, null, null, options,
                            new HelpInfo(helpFilePath, navigator, param),
                            showCtrlCopy, messageBoxButtonTypeface,
                            messageBoxTypeface,
                            null, null, null, null, null,
                            null, null, null, null, null,
                            null, null, null, null,
                            null, null, null, null,
                            null, null, null, string.Empty,
                            null);


        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption" >The text to display in the title bar of the message box. default="string.Empty"</param>
        /// <param name="buttons" >One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon" >One of the KryptonMessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton" >One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options" >One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help button.</param>
        /// <param name="navigator">One of the System.Windows.Forms.HelpNavigator values.</param>
        /// <param name="param">The numeric ID of the Help topic to display when the user clicks the Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(string text, string caption, ExtendedMessageBoxButtons buttons,
                                        ExtendedKryptonMessageBoxIcon icon, MessageBoxDefaultButton defaultButton,
                                        MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param,
                                        bool? showCtrlCopy = null)
            => InternalShow(null, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                            icon, defaultButton, null, null, null,
                            options, new HelpInfo(helpFilePath, navigator, param),
                            showCtrlCopy, null, null,
                            null, null, null, null, null,
                            null, null, null, null, null,
                            null, null, null, null,
                            null, null, null, null,
                            null, null, null, string.Empty,
                            null);

        /// <summary>
        /// Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button, using the specified Help file, HelpNavigator, and Help topic.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon">One of the System.Windows.Forms.MessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help button.</param>
        /// <param name="navigator">One of the System.Windows.Forms.HelpNavigator values.</param>
        /// <param name="param">The numeric ID of the Help topic to display when the user clicks the Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <param name="messageBoxButtonTypeface" default="null">The messagebox button typeface.</param>
        /// <param name="messageBoxTypeface" default="null">The messagebox typeface.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, ExtendedMessageBoxButtons buttons,
                                        ExtendedKryptonMessageBoxIcon icon, MessageBoxDefaultButton defaultButton,
                                        MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param,
                                        bool? showCtrlCopy = null,
                                        Font? messageBoxButtonTypeface = null, Font? messageBoxTypeface = null)
            => InternalShow(owner, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                            icon, defaultButton,
                            null, null, null, options,
                            new HelpInfo(helpFilePath, navigator, param),
                            showCtrlCopy,
                            messageBoxButtonTypeface, messageBoxTypeface,
                            null, null, null, null, null,
                            null, null, null, null, null,
                            null, null, null, null,
                            null, null, null, null,
                            null, null, null, string.Empty,
                            null);

        /// <summary>
        /// Displays a message box with the specified text, caption, buttons, icon, default button, options, and Help button, using the specified Help file, HelpNavigator, and Help topic.
        /// </summary>
        /// <param name="owner">Owner of the modal dialog box.</param>
        /// <param name="text">The text to display in the message box.</param>
        /// <param name="caption">The text to display in the title bar of the message box.</param>
        /// <param name="buttons">One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.</param>
        /// <param name="icon">One of the KryptonMessageBoxIcon values that specifies which icon to display in the message box.</param>
        /// <param name="defaultButton">One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.</param>
        /// <param name="options">One of the System.Windows.Forms.MessageBoxOptions values that specifies which display and association options will be used for the message box. You may pass in 0 if you wish to use the defaults.</param>
        /// <param name="helpFilePath">The path and name of the Help file to display when the user clicks the Help button.</param>
        /// <param name="navigator">One of the System.Windows.Forms.HelpNavigator values.</param>
        /// <param name="param">The numeric ID of the Help topic to display when the user clicks the Help button.</param>
        /// <param name="showCtrlCopy">Show extraText in title. If null(default) then only when Warning or Error icon is used.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption, ExtendedMessageBoxButtons buttons,
                                        ExtendedKryptonMessageBoxIcon icon, MessageBoxDefaultButton defaultButton,
                                        MessageBoxOptions options, string helpFilePath, HelpNavigator navigator, object param,
                                        bool? showCtrlCopy = null)
            => InternalShow(owner, text, caption, buttons, null, string.Empty, string.Empty, string.Empty,
                            icon, defaultButton, null, null, null,
                            options, new HelpInfo(helpFilePath, navigator, param),
                            showCtrlCopy, null, null,
                            null, null, null, null, null,
                            null, null, null, null, null,
                            null, null, null, null,
                            null, null, null, null,
                            null, null, null, string.Empty,
                            null);


        /// <summary>Displays a message box, with all options.</summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="options">The options.</param>
        /// <param name="displayHelpButton">if set to <c>true</c> [display help button].</param>
        /// <param name="helpFilePath">The help file path.</param>
        /// <param name="navigator">The navigator.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="customButtonOneDialogResult">The custom button one dialog result.</param>
        /// <param name="customButtonTwoDialogResult">The custom button two dialog result.</param>
        /// <param name="customButtonThreeDialogResult">The custom button three dialog result.</param>
        /// <param name="showCtrlCopy">The show control copy.</param>
        /// <param name="messageBoxButtonTypeface">The message box button typeface.</param>
        /// <param name="messageBoxTypeface">The message box typeface.</param>
        /// <param name="customButtonVisibility">The custom button visibility.</param>
        /// <param name="buttonOneText">The button one text.</param>
        /// <param name="buttonTwoText">The button two text.</param>
        /// <param name="buttonThreeText">The button three text.</param>
        /// <param name="useYesNoOrCancelButtonColours">The use yes no or cancel button colours.</param>
        /// <param name="contentMessageColour">The content message colour.</param>
        /// <param name="buttonOneBackColourOne">The button one back colour one.</param>
        /// <param name="buttonOneBackColourTwo">The button one back colour two.</param>
        /// <param name="buttonOneTextColourOne">The button one text colour one.</param>
        /// <param name="buttonOneTextColourTwo">The button one text colour two.</param>
        /// <param name="buttonTwoTextColourOne">The button two text colour one.</param>
        /// <param name="buttonTwoTextColourTwo">The button two text colour two.</param>
        /// <param name="buttonTwoBackColourOne">The button two back colour one.</param>
        /// <param name="buttonTwoBackColourTwo">The button two back colour two.</param>
        /// <param name="buttonThreeTextColourOne">The button three text colour one.</param>
        /// <param name="buttonThreeTextColourTwo">The button three text colour two.</param>
        /// <param name="buttonThreeBackColourOne">The button three back colour one.</param>
        /// <param name="buttonThreeBackColourTwo">The button three back colour two.</param>
        /// <param name="yesButtonBackColourOne">The yes button back colour one.</param>
        /// <param name="yesButtonBackColourTwo">The yes button back colour two.</param>
        /// <param name="yesButtonTextColourOne">The yes button text colour one.</param>
        /// <param name="yesButtonTextColourTwo">The yes button text colour two.</param>
        /// <param name="noButtonBackColourOne">The no button back colour one.</param>
        /// <param name="noButtonBackColourTwo">The no button back colour two.</param>
        /// <param name="noButtonTextColourOne">The no button text colour one.</param>
        /// <param name="noButtonTextColourTwo">The no button text colour two.</param>
        /// <param name="buttonCornerRounding">The button corner rounding.</param>
        /// <param name="windowCornerRounding">The window corner rounding.</param>
        /// <param name="showUacShieldOnAcceptButton">The show uac shield on accept button.</param>
        /// <param name="showOptionalCheckBox">The show optional CheckBox.</param>
        /// <param name="isOptionalCheckBoxChecked">The is optional CheckBox checked.</param>
        /// <param name="optionalCheckBoxTextColourOne">The optional CheckBox text colour one.</param>
        /// <param name="optionalCheckBoxTextColourTwo">The optional CheckBox text colour two.</param>
        /// <param name="optionalCheckBoxTypeface">The optional CheckBox typeface.</param>
        /// <param name="optionalCheckBoxText">The optional CheckBox text.</param>
        /// <param name="optionalCheckBoxCheckState">State of the optional CheckBox check.</param>
        /// <returns>One of the System.Windows.Forms.DialogResult values.</returns>
        public static DialogResult Show(IWin32Window owner, string text, string caption,
            ExtendedMessageBoxButtons buttons,
            ExtendedKryptonMessageBoxIcon icon, MessageBoxDefaultButton defaultButton,
            MessageBoxOptions options, bool displayHelpButton,
            string helpFilePath, HelpNavigator navigator, object param,
            DialogResult? customButtonOneDialogResult, DialogResult? customButtonTwoDialogResult,
            DialogResult? customButtonThreeDialogResult, bool? showCtrlCopy,
            Font? messageBoxButtonTypeface, Font? messageBoxTypeface,
            ExtendedMessageBoxCustomButtonVisibility? customButtonVisibility,
            string buttonOneText, string buttonTwoText, string buttonThreeText,
            bool? useYesNoOrCancelButtonColours, Color? contentMessageColour,
            Color? buttonOneBackColourOne, Color? buttonOneBackColourTwo,
            Color? buttonOneTextColourOne, Color? buttonOneTextColourTwo,
            Color? buttonTwoTextColourOne, Color? buttonTwoTextColourTwo,
            Color? buttonTwoBackColourOne, Color? buttonTwoBackColourTwo,
            Color? buttonThreeTextColourOne, Color? buttonThreeTextColourTwo,
            Color? buttonThreeBackColourOne, Color? buttonThreeBackColourTwo,
            Color? yesButtonBackColourOne, Color? yesButtonBackColourTwo,
            Color? yesButtonTextColourOne, Color? yesButtonTextColourTwo,
            Color? noButtonBackColourOne, Color? noButtonBackColourTwo,
            Color? noButtonTextColourOne, Color? noButtonTextColourTwo,
            float? buttonCornerRounding, float? windowCornerRounding,
            bool? showUacShieldOnAcceptButton, bool? showOptionalCheckBox,
            bool? isOptionalCheckBoxChecked, Color? optionalCheckBoxTextColourOne,
            Color? optionalCheckBoxTextColourTwo, Font? optionalCheckBoxTypeface,
            string optionalCheckBoxText, CheckState? optionalCheckBoxCheckState)
            => InternalShow(owner, text, caption, buttons, customButtonVisibility, buttonOneText, buttonTwoText, buttonThreeText, icon,
                defaultButton, customButtonOneDialogResult, customButtonTwoDialogResult,
                customButtonThreeDialogResult, options, displayHelpButton ? new HelpInfo(helpFilePath, navigator, param) : null,
                showCtrlCopy, messageBoxButtonTypeface, messageBoxTypeface,
                contentMessageColour, buttonOneBackColourOne, buttonOneBackColourTwo,
                buttonOneTextColourOne, buttonOneTextColourTwo, buttonTwoTextColourOne,
                buttonTwoTextColourTwo, buttonTwoBackColourOne, buttonTwoBackColourTwo,
                buttonThreeTextColourOne, buttonThreeTextColourTwo, buttonThreeBackColourOne,
                buttonThreeBackColourTwo, buttonCornerRounding, windowCornerRounding,
                showUacShieldOnAcceptButton, showOptionalCheckBox, isOptionalCheckBoxChecked,
                optionalCheckBoxTextColourOne, optionalCheckBoxTextColourTwo, optionalCheckBoxTypeface,
                optionalCheckBoxText, optionalCheckBoxCheckState);
        #endregion

        #region Implementation

        /// <summary>Shows the messagebox.</summary>
        /// <param name="owner">The owner.</param>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="customButtonVisibility">The custom button visibility.</param>
        /// <param name="buttonOneText">The button one text.</param>
        /// <param name="buttonTwoText">The button two text.</param>
        /// <param name="buttonThreeText">The button three text.</param>
        /// <param name="icon">The icon.</param>
        /// <param name="defaultButton">The default button.</param>
        /// <param name="customButtonOneDialogResult">The custom button one dialog result.</param>
        /// <param name="customButtonTwoDialogResult">The custom button two dialog result.</param>
        /// <param name="customButtonThreeDialogResult">The custom button three dialog result.</param>
        /// <param name="options">The options.</param>
        /// <param name="helpInfo">The help information.</param>
        /// <param name="showCtrlCopy">The show control copy.</param>
        /// <param name="messageBoxButtonTypeface">The message box button typeface.</param>
        /// <param name="messageBoxTypeface">The message box typeface.</param>
        /// <param name="contentMessageColour">The content message colour.</param>
        /// <param name="buttonOneBackColourOne">The button one back colour one.</param>
        /// <param name="buttonOneBackColourTwo">The button one back colour two.</param>
        /// <param name="buttonOneTextColourOne">The button one text colour one.</param>
        /// <param name="buttonOneTextColourTwo">The button one text colour two.</param>
        /// <param name="buttonTwoTextColourOne">The button two text colour one.</param>
        /// <param name="buttonTwoTextColourTwo">The button two text colour two.</param>
        /// <param name="buttonTwoBackColourOne">The button two back colour one.</param>
        /// <param name="buttonTwoBackColourTwo">The button two back colour two.</param>
        /// <param name="buttonThreeTextColourOne">The button three text colour one.</param>
        /// <param name="buttonThreeTextColourTwo">The button three text colour two.</param>
        /// <param name="buttonThreeBackColourOne">The button three back colour one.</param>
        /// <param name="buttonThreeBackColourTwo">The button three back colour two.</param>
        /// <param name="buttonCornerRounding">The button corner rounding.</param>
        /// <param name="windowCornerRounding">The window corner rounding.</param>
        /// <param name="showUacShieldOnAcceptButton">The show uac shield on accept button.</param>
        /// <param name="showOptionalCheckBox">The show optional CheckBox.</param>
        /// <param name="isOptionalCheckBoxChecked">The is optional CheckBox checked.</param>
        /// <param name="optionalCheckBoxTextColourOne">The optional CheckBox text colour one.</param>
        /// <param name="optionalCheckBoxTextColourTwo">The optional CheckBox text colour two.</param>
        /// <param name="optionalCheckBoxTypeface">The optional CheckBox typeface.</param>
        /// <param name="optionalCheckBoxText">The optional CheckBox text.</param>
        /// <param name="optionalCheckBoxCheckState"></param>
        private static DialogResult InternalShow(IWin32Window owner, string text, string caption,
                                               ExtendedMessageBoxButtons buttons,
                                               ExtendedMessageBoxCustomButtonVisibility? customButtonVisibility,
                                               string buttonOneText, string buttonTwoText, string buttonThreeText,
                                               ExtendedKryptonMessageBoxIcon icon, MessageBoxDefaultButton defaultButton,
                                               DialogResult? customButtonOneDialogResult, DialogResult? customButtonTwoDialogResult,
                                               DialogResult? customButtonThreeDialogResult, MessageBoxOptions options,
                                               HelpInfo helpInfo, bool? showCtrlCopy,
                                               Font? messageBoxButtonTypeface, Font? messageBoxTypeface,
                                               Color? contentMessageColour,
                                               Color? buttonOneBackColourOne, Color? buttonOneBackColourTwo,
                                               Color? buttonOneTextColourOne, Color? buttonOneTextColourTwo,
                                               Color? buttonTwoTextColourOne, Color? buttonTwoTextColourTwo,
                                               Color? buttonTwoBackColourOne, Color? buttonTwoBackColourTwo,
                                               Color? buttonThreeTextColourOne, Color? buttonThreeTextColourTwo,
                                               Color? buttonThreeBackColourOne, Color? buttonThreeBackColourTwo,
                                               float? buttonCornerRounding, float? windowCornerRounding,
                                               bool? showUacShieldOnAcceptButton, bool? showOptionalCheckBox,
                                               bool? isOptionalCheckBoxChecked, Color? optionalCheckBoxTextColourOne,
                                               Color? optionalCheckBoxTextColourTwo, Font? optionalCheckBoxTypeface,
                                               string optionalCheckBoxText, CheckState? optionalCheckBoxCheckState)
        {
            IWin32Window showOwner = ValidateOptions(owner, options, helpInfo);

            using KryptonMessageBoxExtendedForm kmbe = new(showOwner, text, caption, buttons, customButtonVisibility,
                                                           buttonOneText, buttonTwoText, buttonThreeText,
                                                           icon, defaultButton, customButtonOneDialogResult,
                                                           customButtonTwoDialogResult, customButtonThreeDialogResult,
                                                           options, helpInfo, showCtrlCopy, messageBoxButtonTypeface,
                                                           messageBoxTypeface,
                                                           contentMessageColour, buttonOneBackColourOne,
                                                           buttonOneBackColourTwo, buttonOneTextColourOne,
                                                           buttonOneTextColourTwo, buttonTwoTextColourOne,
                                                           buttonTwoTextColourTwo, buttonTwoBackColourOne,
                                                           buttonTwoBackColourTwo, buttonThreeTextColourOne,
                                                           buttonThreeTextColourTwo, buttonThreeBackColourOne,
                                                           buttonThreeBackColourTwo,
                                                           buttonCornerRounding, windowCornerRounding,
                                                           showUacShieldOnAcceptButton, showOptionalCheckBox,
                                                           isOptionalCheckBoxChecked, optionalCheckBoxTextColourOne,
                                                           optionalCheckBoxTextColourTwo, optionalCheckBoxTypeface,
                                                           optionalCheckBoxText, optionalCheckBoxCheckState
                                                           );

            kmbe.StartPosition = showOwner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;

            return kmbe.ShowDialog(showOwner);
        }

        #region WinForm Compatibility
        private static IWin32Window ValidateOptions(IWin32Window owner, MessageBoxOptions options, HelpInfo helpInfo)
        {
            // Check if trying to show a message box from a non-interactive process, this is not possible
            if (!SystemInformation.UserInteractive &&
                ((options & (MessageBoxOptions.ServiceNotification | MessageBoxOptions.DefaultDesktopOnly)) == 0))
            {
                throw new InvalidOperationException("Cannot show modal dialog when non-interactive");
            }

            // Check if trying to show a message box from a service and the owner has been specified, this is not possible
            if ((owner != null) &&
                ((options & (MessageBoxOptions.ServiceNotification | MessageBoxOptions.DefaultDesktopOnly)) != 0))
            {
                throw new ArgumentException(@"Cannot show message box from a service with an owner specified", nameof(options));
            }

            // Check if trying to show a message box from a service and help information is specified, this is not possible
            if ((helpInfo != null) &&
                ((options & (MessageBoxOptions.ServiceNotification | MessageBoxOptions.DefaultDesktopOnly)) != 0))
            {
                throw new ArgumentException(@"Cannot show message box from a service with help specified", nameof(options));
            }

            IWin32Window showOwner = null;
            if ((helpInfo != null) ||
                ((options & (MessageBoxOptions.ServiceNotification | MessageBoxOptions.DefaultDesktopOnly)) == 0))
            {
                // If do not have an owner passed in then get the active window and use that instead
                showOwner = owner ?? Control.FromHandle(PI.GetActiveWindow());
            }

            return showOwner;
        }
        #endregion

        #endregion
    }
}