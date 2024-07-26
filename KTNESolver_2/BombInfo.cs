using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNESolver_2
{
    public struct bombInfo
    {
        public int batteryCount;
        public bool serialEven;
        public bool hasParallel;
        public bool serialVowel;
        public bool hasFRK;
        public bool hasCAR;
        public int strikes;

        public bombInfo(int _batteryCount, bool _serialEven, bool _serialVowel, bool _hasParallel, bool _hasFRK, bool _hasCAR, int _strikes)
        {
            this.batteryCount = _batteryCount;
            this.serialEven = _serialEven;
            this.serialVowel = _serialVowel;
            this.hasParallel = _hasParallel;
            this.hasFRK = _hasFRK;
            this.hasCAR = _hasCAR;
            this.strikes = _strikes;
        }
    }
}
