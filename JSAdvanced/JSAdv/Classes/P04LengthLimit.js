class Stringer{
    constructor(innerString,innerLength){
        this.innerString=innerString;
        this.innerLength=parseInt(innerLength);
    }

    increase(length){
        this.innerLength+=length;
    }
    decrease(length){
        this.innerLength-=length;
        if(this.innerLength<0){
            this.innerLength=0;
        }
    }
    toString(){
        let result='';
        if(this.innerLength===0){
            result='...';
        } else if(this.innerString.length > this.innerLength){
            result = this.innerString.substr(0,this.innerLength)+'...';
        } else {
            result = this.innerString;
        }
        return result;
    }
}