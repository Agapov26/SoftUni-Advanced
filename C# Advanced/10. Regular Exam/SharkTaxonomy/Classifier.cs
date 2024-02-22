using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount { get => Species.Count; }

        public void AddShark(Shark shark)
        {
            if (!Species.Any(x => x.Kind == shark.Kind))
            {
                if (Species.Count < Capacity)
                {
                    Species.Add(shark);
                }
            }
        }

        public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(k => k.Kind == kind));

        public string GetLargestShark()
        {
            Shark largestShark = Species.OrderByDescending(m => m.Length).First();
            return largestShark.ToString();
        }

        public double GetAverageLength()
        {
            return Species.Average(s => s.Length);
        }

        public string Report()
        {
            var report = new StringBuilder();
            report.AppendLine($"{Species.Count} sharks classified:");
            foreach (var shark in Species)
            {
                report.AppendLine(shark.ToString());
            }
            return report.ToString().TrimEnd();
        }
    }
}
