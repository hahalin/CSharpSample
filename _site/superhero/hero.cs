using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel; //重要

namespace acerclass
{

    public enum HeroGroup{ east,west};
    
    public enum HeroAbility {
        [Description("IQ")]
        IQ,
        [Description("Power")]
        Power,
        [Description("Magic")]
        Magic,
        [Description("Fly")]
        Fly 
    };

    public class Hero
    {
        public Hero()
        {
            this.abilities = new List<HeroAbility>();
        }

        
        public override string ToString()
        {
            return  this.cname + "(" + this.ename +")";
            
        }
        


        public string cname
        {
            get;

            set;
        }

        public string ename
        {
            get;
            set;
        }

        public HeroGroup HGroup
        {
            get;
            set;
        }

        public List<HeroAbility> abilities
        {
            get;
            
            set;
        }
        public string slogan
        {
            get;
            set;
        }

        public string photoFilename
        {
            get;
            set;
        }
        
    }
}


/*

 hero slogan
 
 ironman: genius billionaire playboy philanthropist
 
 spider: with the great power comes great responsibility
 
 thor: I will be back
 
 Capital Amerian: go ! go ! go !
 
 孔明: 你過時了
 
 sometimes:嗶嗶嗶嗶嗶!!! 

 悟空:老孫來也
 
 達摩: 路行跨水復逢春，獨自淒淒暗渡江。日下可憐雙象馬，二株嫩桂久昌昌
 
*/