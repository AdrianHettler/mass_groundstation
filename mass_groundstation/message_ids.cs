using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mass_groundstation
{
    class message_ids
    {
        //System Commands
        public const byte OK = 1;
        public const byte TCP_UDP_PING = 2;
        public const byte TCP_PONG = 3;
        public const byte UDP_PONG = 4;
        public const byte RESET = 5;
        public const byte ERROR = 254;

        //Experiment Commands
        public const byte EXP_LIFT_OFF = 20;
        public const byte EXP_START_INFLATION = 21;
        public const byte EXP_UV_ON = 22;
        public const byte EXP_UV_OFF = 23;
        public const byte EXP_CAM_START = 21;
        public const byte EXP_CAM_STOP = 21;

        //Downlink
        public const byte DATA_ENVIROMENTAL = 100;
        public const byte DATA_POWER = 101;
        public const byte DATA_PNEUMATICS = 102;
    }
}
