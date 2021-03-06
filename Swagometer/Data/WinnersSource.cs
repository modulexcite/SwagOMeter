using System;
using System.Collections.Generic;
using System.Linq;
using Swagometer.Collections;

namespace Swagometer.Data
{
    public class WinnersSource : IWinnersSource
    {
        public void Save(IList<IWinner> winners)
        {
            if (winners != null)
            {
                var winnersOutput = WinnersCollection.Create();

                foreach (var winner in winners)
                    winnersOutput.Add(winner);

                winnersOutput.Save();
            }
        }
    }
}
