using System.Linq;
using Newtonsoft.Json;

namespace CollectionViewChallenge.Models
{
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("team_acronym")]
        public string TeamAcronym { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("games_played")]
        public string GamesPlayed { get; set; }

        [JsonProperty("minutes_per_game")]
        public string MinutesPerGame { get; set; }

        [JsonProperty("field_goals_attempted_per_game")]
        public string FieldGoalsAttemptedPerGame { get; set; }

        [JsonProperty("field_goals_made_per_game")]
        public string FieldGoalsMadePerGame { get; set; }

        [JsonProperty("field_goal_percentage")]
        public string FieldGoalPercentage { get; set; }

        [JsonProperty("free_throw_percentage")]
        public string FreeThrowPercentage { get; set; }

        [JsonProperty("three_point_attempted_per_game")]
        public string ThreePointAttemptedPerGame { get; set; }

        [JsonProperty("three_point_made_per_game")]
        public string ThreePointMadePerGame { get; set; }

        [JsonProperty("three_point_percentage")]
        public string ThreePointPercentage { get; set; }

        [JsonProperty("points_per_game")]
        public string PointsPerGame { get; set; }

        [JsonProperty("offensive_rebounds_per_game")]
        public string OffensiveReboundsPerGame { get; set; }

        [JsonProperty("defensive_rebounds_per_game")]
        public string DefensiveReboundsPerGame { get; set; }

        [JsonProperty("rebounds_per_game")]
        public string ReboundsPerGame { get; set; }

        [JsonProperty("assists_per_game")]
        public string AssistsPerGame { get; set; }

        [JsonProperty("steals_per_game")]
        public string StealsPerGame { get; set; }

        [JsonProperty("blocks_per_game")]
        public string BlocksPerGame { get; set; }

        [JsonProperty("turnovers_per_game")]
        public string TurnoversPerGame { get; set; }

        [JsonProperty("player_efficiency_rating")]
        public string PlayerEfficiencyRating { get; set; }

        public string Image => GetImage();

        private string GetImage()
        {
            return "https://nba-players.herokuapp.com/players/" + string.Join("/", Name.ToLower().Split(' ').Reverse().ToList());
        }
    }
}

