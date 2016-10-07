using System;
using System.Collections.Generic;
using System.Linq;
using IntergalacticTravel;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravelTests.TeleportStationTests.Mocks
{
    public class TeleportStationMock : TeleportStation
    {
        public TeleportStationMock(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) 
            : base(owner, galacticMap, location)
        {
        }

        public IBusinessOwner Owner => base.owner;

        public IEnumerable<IPath> GalacticMap => base.galacticMap;

        public ILocation Location => base.location;
    }
}
