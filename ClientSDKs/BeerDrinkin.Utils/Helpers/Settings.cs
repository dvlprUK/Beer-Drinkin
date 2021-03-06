// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace BeerDrinkin.Utils.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;

        private const string UserIdKey = "userId_key";
        private static readonly string UserIdDefault = string.Empty;

        private const string LocationEnabledKey = "locaiton_enabled_key";
        private static readonly bool LocationEnabledDefault = false;

        #endregion


        public static string GeneralSettings
        {
          get
          {
            return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
          }
          set
          {
            AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
          }
        }

        public static string UserId
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(UserIdKey, value);
            }
        }

        public static bool LocationEnabled
        {
            get
            {
                return AppSettings.GetValueOrDefault<bool>(LocationEnabledKey, LocationEnabledDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<bool>(LocationEnabledKey, value);
            }
        }

    }
}