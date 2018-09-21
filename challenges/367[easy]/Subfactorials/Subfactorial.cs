/// <summary>
/// Implements the subfactorial for the /r/dailyprogrammer challenge 367 [Easy]
/// </summary>
namespace Subfactorials {
    public class Subfactorial {

        public long Dearangement(long value) {
            long dearangeResult;
            if(value == 1)
                dearangeResult = 0;
            else if(value == 2)
                dearangeResult = 1;
            else if(value == 3)
                dearangeResult = 2;
            else
                dearangeResult = (value - 1) * (Dearangement(value - 1) + Dearangement(value - 2));
            return dearangeResult;
        }
    }
}
