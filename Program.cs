using System;

KodePos kodePos = new KodePos();
int batununggal = kodePos.getKodePos("Batununggal");
int wates = kodePos.getKodePos("Wates");
Console.WriteLine("Kode Pos Batununggal: " + batununggal);
Console.WriteLine("Kode Pos Wates: " + wates);

public class KodePos
{
    public int getKodePos(string kelurahan)
    {
        if(kelurahan == "Batununggal")
        {
            return 40266;
        }
        else if(kelurahan == "Kujangsari")
        {
            return 40287;
        }
        else if(kelurahan == "Mengger")
        {
            return 40267;
        }
        else if(kelurahan == "Wates")
        {
            return 40256;
        }
        else if(kelurahan == "Cijaura")
        {
            return 40287;
        }
        else if(kelurahan == "Jatisari")
        {
            return 40286;
        }
        else if (kelurahan == "Margasari")
        {
            return 40286;
        }
        else if (kelurahan == "Sekejati")
        {
            return 40286;
        }
        else if (kelurahan == "Kebonwaru")
        {
            return 40272;
        }
        else if (kelurahan == "Maleer")
        {
            return 40274;
        }
        else
        {
            return 0;
        }
    }
}