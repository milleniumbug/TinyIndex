﻿namespace TinyIndex
{
    public interface ISerializer<T>
    {
        T Deserialize(byte[] sourceBuffer, int sourceBufferOffset, int sourceBufferLength);

        // serialize to the destination buffer
        // method should return true if the serialization succeeded
        // if the serialization failed because of insufficient destination buffer size,
        // the method should return false. in which case the caller can't assume anything
        // about the content of destinationBuffer[destinationBufferOffset .. destinationBufferOffset + destinationBufferLength]
        // the serialization shall not fail for any other reason
        bool TrySerialize(T element, byte[] destinationBuffer, int destinationBufferOffset, int destinationBufferLength);
    }
}