public static class ByteConverter
{
    public static unsafe int GetInt(byte[] bytes, int index)
    {
        int retVal;
        fixed (byte* pbytes = &bytes[index])
        {
            retVal = *(int*)pbytes;
        }
        return retVal;
    }
    public static unsafe void SetInt(int inVal, byte[] bytes, int index)
    {
        fixed(byte* pbytes = &bytes[index])
        {
            *(int*)pbytes = inVal;
        }
    }
    public static unsafe uint GetUint(byte[] bytes, int index)
    {
        uint retVal;
        fixed (byte* pbytes = &bytes[index])
        {
            retVal = *(uint*)pbytes;
        }
        return retVal;
    }
    public static unsafe void SetUint(uint inVal, byte[] bytes, int index)
    {
        fixed (byte* pbytes = &bytes[index])
        {
            *(uint*)pbytes = inVal;
        }
    }
    public static unsafe ushort GetUshort(byte[] bytes, int index)
    {
        ushort retVal;
        fixed (byte* pbytes = &bytes[index])
        {
            retVal = *(ushort*)pbytes;
        }
        return retVal;
    }
    public static unsafe void SetShort(short inVal, byte[] bytes, int index)
    {
        fixed(byte* pbytes = &bytes[index])
        {
            *(short*)pbytes = inVal;
        }
    }
    public static unsafe short GetShort(byte[] bytes, int index)
    {
        short retVal;
        fixed (byte* pbytes = &bytes[index])
        {
            retVal = *(short*)pbytes;
        }
        return retVal;
    }
    public static unsafe void SetUshort(ushort inVal, byte[] bytes, int index)
    {
        fixed (byte* pbytes = &bytes[index])
        {
            *(ushort*)pbytes = inVal;
        }
    }
    public static unsafe void setByte(byte inVal, byte[] bytes, int index)
    {
        bytes[index] = inVal;
    }
    public static unsafe byte getByte(byte[] bytes, int index)
    {
        return bytes[index];
    }
};