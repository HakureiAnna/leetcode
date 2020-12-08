public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        uint bit = 0;
        for (var i=0; i<32; ++i) {
            res <<= 1;
            bit = n & 0x1;
            res |= bit;
            n >>= 1;
        }
        return res;
    }
}