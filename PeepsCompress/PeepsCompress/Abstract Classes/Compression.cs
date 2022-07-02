using System.IO;
using System.Collections.Generic;

namespace PeepsCompress
{
    public abstract class Compression
    {
        public abstract byte[] compress(byte[] file, int offset);
        public abstract byte[] compressInitialization(string path, bool fileInputMode);
        public abstract byte[] decompress(BinaryReader br, int offset, FileStream inputFile);
        public abstract byte[] decompressInitialization(string path, int offset);
        public abstract List<int> findOccurencesOfHeader(string path);
    }
}
