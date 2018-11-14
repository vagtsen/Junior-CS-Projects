using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public enum ReturnStatus{OK,Fail}

    public interface Storable
    {
        //methodos  
        ReturnStatus Status{get;set;}

        //h suntaksh ths methodou allazei
        //de dexetai access modifier einai public apo th fush tous
        //anamenoume objects classewn na einai storable
        //Mazeuei mia sugkekrimenh leitourgikothta
        //To interface einai ena sunolo apo properties kai methodous pou an ikanopoiountai dinoun kati
        void Write(object obj);
        String Read();

    }
}
