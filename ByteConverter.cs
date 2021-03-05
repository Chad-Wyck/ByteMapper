public static class ByteConverter
{
    public static unsafe float GetFloat(byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            return *(float*)pbytes;
    }
    public static unsafe void SetFloat(float inVal, byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            *(float*)pbytes = inVal;
    }
    public static unsafe int GetInt(byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            return *(int*)pbytes;
    }
    public static unsafe void SetInt(int inVal, byte[] bytes, uint index)
    {
        fixed(byte* pbytes = &bytes[index])
            *(int*)pbytes = inVal;
    }
    public static unsafe uint GetUint(byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            return *(uint*)pbytes;
    }
    public static unsafe void SetUint(uint inVal, byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            *(uint*)pbytes = inVal;
    }
    public static unsafe ushort GetUshort(byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            return *(ushort*)pbytes;
    }
    public static unsafe void SetShort(short inVal, byte[] bytes, uint index)
    {
        fixed(byte* pbytes = &bytes[index])
            *(short*)pbytes = inVal;
    }
    public static unsafe short GetShort(byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            return *(short*)pbytes;
    }
    public static unsafe void SetUshort(ushort inVal, byte[] bytes, uint index)
    {
        fixed (byte* pbytes = &bytes[index])
            *(ushort*)pbytes = inVal;
    }
    public static unsafe void SetByte(byte inVal, byte[] bytes, uint index)
    {
        bytes[index] = inVal;
    }
    public static unsafe byte GetByte(byte[] bytes, uint index)
    {
        return bytes[index];
    }
};
