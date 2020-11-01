﻿using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Krypton.Toolkit.Suite.Extended.Outlook.Grid
{
    /// <summary>
    /// This class handles the current localisation
    /// </summary>
    public class LanguageManager
    {
        // Local variable to store a reference to the instance of LanguageManager
        public static LanguageManager languageManager = null;

        public static readonly object myLock = new object();

        public ResourceManager resourceManagerUS, resourceManagerGB, resourceManagerFR;

        private CultureInfo cultureInfo;

        //Used for blocking critical sections on updates
        private object locker = new object();

        private LanguageManager()
        {
            resourceManagerUS = new ResourceManager("Krypton.Toolkit.Suite.Extended.Outlook.Grid.Utilities.Language.EnglishStringsUS", Assembly.GetExecutingAssembly());

            resourceManagerGB = new ResourceManager("Krypton.Toolkit.Suite.Extended.Outlook.Grid.Utilities.Language.EnglishStringsGB", Assembly.GetExecutingAssembly());

            resourceManagerFR = new ResourceManager("Krypton.Toolkit.Suite.Extended.Outlook.Grid.Utilities.Language.FrenchStrings", Assembly.GetExecutingAssembly());

            cultureInfo = Thread.CurrentThread.CurrentCulture;
        }

        /// <summary>
        /// Gets or sets the P locker.
        /// </summary>
        /// <value>The P locker.</value>
        public object PLocker { get => locker; set => locker = value; }

        /// <summary>
        /// Gets the instance of the singleton.
        /// </summary>
        public static LanguageManager Instance
        {
            get
            {
                if (languageManager == null)
                {
                    lock (myLock)
                    {
                        if (languageManager == null)
                        {
                            languageManager = new LanguageManager();
                        }
                    }
                }

                return languageManager;
            }
        }

        /// <summary>
        /// Get localised string for USA
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public string GetStringUS(string name) => resourceManagerUS.GetString(name, cultureInfo);

        /// <summary>
        /// Get localised string for GB
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetStringGB(string name) => resourceManagerGB.GetString(name, cultureInfo);

        /// <summary>Gets localised string for FR.</summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public string GetStringFR(string name) => resourceManagerFR.GetString(name, cultureInfo);
    }
}