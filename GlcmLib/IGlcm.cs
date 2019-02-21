using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GlcmLib
{
    public interface IGlcm
    {
        // GLCM
        void GetGlcm(FileInfo image);

        // contrast:
        string CON();
        // second angular momentum of the adjacency matrix:
        string ASM();
        // entropy:
        string ENT();
        // correlation
        string COR();


    }
}
