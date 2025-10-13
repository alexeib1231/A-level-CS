
using System.Diagnostics;

UInt32 rightmostbit(UInt32 n)
{
    return n & 1;
}
Debug.Assert(rightmostbit(10) == 0);

UInt32 threerightmostbits(UInt32 n)
{
    return n & 0b111;
}
Debug.Assert(threerightmostbits(1000) == 000);

UInt32 leftmostbit(UInt32 n)
{
    return (n >> 31) & 1;
}
Debug.Assert(leftmostbit(uint.MaxValue) == 1);

UInt32 threeleftmostbits(UInt32 n)
{
    return (n >> 29) & 0b111;
}
Debug.Assert(threeleftmostbits(uint.MaxValue) == 111);