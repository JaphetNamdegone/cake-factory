﻿using CakeMachine.Fabrication.ContexteProduction;
using CakeMachine.Fabrication.Elements;

namespace CakeMachine.Simulation.Algorithmes
{
    internal abstract class Algorithme
    {
        public virtual bool SupportsAsync => false;
        public virtual bool SupportsSync => false;

        public virtual void ConfigurerUsine(IConfigurationUsine builder) { }

        public virtual IEnumerable<GâteauEmballé> Produire(Usine usine, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public virtual IAsyncEnumerable<GâteauEmballé> ProduireAsync(Usine usine, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
