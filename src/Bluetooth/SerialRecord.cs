namespace Rogue.HeartTracker.Bluetooth
{
    public class SerialRecord
    {
        public byte[] Data { get; private set; }

        public SerialRecord(byte[] data)
        {
            Data = data;
        }
    }
}
