using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private HashSet<string> peaksConquered;

        public Climber(string name, int stamina)
        {
            Name = name;
            Stamina = stamina;
            peaksConquered = new();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClimberNameNullOrWhiteSpace);
                }

                name = value;
            }
        }

        public int Stamina
        {
            get => stamina;

            protected set
            {
                if (value > 10)
                {
                    stamina = 10;
                }

                else if (value < 0)
                {
                    stamina = 0;
                }

                else
                {
                    stamina = value;
                }
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks => peaksConquered;

        public void Climb(IPeak peak)
        {
            peaksConquered.Add(peak.Name);

            if (peak.DifficultyLevel == "Extreme")
            {
                Stamina -= 6;
            }

            else if (peak.DifficultyLevel == "Hard")
            {
                Stamina -= 4;
            }

            else if (peak.DifficultyLevel == "Moderate")
            {
                Stamina -= 2;
            }
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name} - Name: {Name}, Stamina: {Stamina}");

            if (peaksConquered.Count == 0)
            {
                sb.AppendLine("Peaks conquered: no peaks conquered");
            }

            else
            {
                sb.AppendLine($"Peaks conquered: {this.peaksConquered.Count}");
            }

            return sb.ToString().Trim();
        }
    }
}
