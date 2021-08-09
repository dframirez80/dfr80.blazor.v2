using System.Collections.Generic;

namespace blazorApp
{
    public class DataApp{
        public double ScrollDataY { get; set;}
        public int SizeScreenY { get; set;}
        public double PositionElement { get; set;}
        public double ShowInfo { get; set;} = 0.7;
        public string EffectHide { get; set;} = "effect-hide";
        public string EffectShow { get; set;} = "effect-hide effect-show";
        public string Effect(){
            if(this.PositionElement < (this.SizeScreenY * this.ShowInfo)){
                return this.EffectShow;
            } else{
                return this.EffectHide;
            }
        }
    }
}