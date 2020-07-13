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
        public const byte TCP_PING = 2;
        public const byte TCP_PONG = 3;
        public const byte UDP_PONG = 4;
        public const byte RESET = 5;
        public const byte PING = 6;
        public const byte ERROR = 254;

        //Experiment Commands
        public const byte EXP_INIT = 20;
        public const byte EXP_RELEASE_STRUCTURES = 21;
        public const byte EXP_START_INFLATION = 22;
        public const byte EXP_UV_ON = 23;
        public const byte EXP_UV_OFF = 24;
        public const byte EXP_CAM_START = 25;
        public const byte EXP_CAM_STOP = 26;
        public const byte EXP_VALVES_MANUAL_ON = 27;
        public const byte EXP_VALVES_MANUAL_OFF = 28;
        public const byte EXP_STOP_INFLATION = 29;

        //Downlink
        public const byte DATA_ENVIROMENTAL = 100;
        public const byte DATA_POWER = 101;
        public const byte DATA_PNEUMATICS = 102;

    }
}
