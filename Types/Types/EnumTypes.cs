using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public enum ConnectionState
    {
        Connected,
        Disconnected
        
    }

    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    public enum ReportType
    {
        Pdf,
        Excel,
        Word,      
        Xml,
        Html,
    }

    public enum ErkekAkrabalikTipleri
    {
        Ogul=1,
        Baba=2,
        Amca=4,
        Dayı=8,
        Dede=16,
        Abi=32
    }
    



}
