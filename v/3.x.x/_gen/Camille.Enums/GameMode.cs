
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-05-12T03:12:38.402Z

using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// GameModes enum based on gameModes.json.
    /// </summary>
#if USE_SYSTEXTJSON
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
#endif
    public enum GameMode
    {
        [Display(Name = "CLASSIC", Description = "Classic Summoner's Rift and Twisted Treeline games")]
        CLASSIC,
        [Display(Name = "ODIN", Description = "Dominion/Crystal Scar games")]
        ODIN,
        [Display(Name = "ARAM", Description = "ARAM games")]
        ARAM,
        [Display(Name = "TUTORIAL", Description = "Tutorial games")]
        TUTORIAL,
        [Display(Name = "URF", Description = "URF games")]
        URF,
        [Display(Name = "DOOMBOTSTEEMO", Description = "Doom Bot games")]
        DOOMBOTSTEEMO,
        [Display(Name = "ONEFORALL", Description = "One for All games")]
        ONEFORALL,
        [Display(Name = "ASCENSION", Description = "Ascension games")]
        ASCENSION,
        [Display(Name = "FIRSTBLOOD", Description = "Snowdown Showdown games")]
        FIRSTBLOOD,
        [Display(Name = "KINGPORO", Description = "Legend of the Poro King games")]
        KINGPORO,
        [Display(Name = "SIEGE", Description = "Nexus Siege games")]
        SIEGE,
        [Display(Name = "ASSASSINATE", Description = "Blood Hunt Assassin games")]
        ASSASSINATE,
        [Display(Name = "ARSR", Description = "All Random Summoner's Rift games")]
        ARSR,
        [Display(Name = "DARKSTAR", Description = "Dark Star: Singularity games")]
        DARKSTAR,
        [Display(Name = "STARGUARDIAN", Description = "Star Guardian Invasion games")]
        STARGUARDIAN,
        [Display(Name = "PROJECT", Description = "PROJECT: Hunters games")]
        PROJECT,
        [Display(Name = "GAMEMODEX", Description = "Nexus Blitz games")]
        GAMEMODEX,
        [Display(Name = "ODYSSEY", Description = "Odyssey: Extraction games")]
        ODYSSEY,
    }
}