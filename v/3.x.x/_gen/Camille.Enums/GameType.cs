
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-04-18T03:10:40.514Z

using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// GameTypes enum based on gameTypes.json.
    /// </summary>
#if USE_SYSTEXTJSON
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
#endif
    public enum GameType
    {
        [Display(Name = "CUSTOM_GAME", Description = "Custom games")]
        CUSTOM_GAME,
        [Display(Name = "TUTORIAL_GAME", Description = "Tutorial games")]
        TUTORIAL_GAME,
        [Display(Name = "MATCHED_GAME", Description = "all other games")]
        MATCHED_GAME,
    }
}
