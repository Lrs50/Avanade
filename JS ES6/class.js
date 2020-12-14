class Animal{
    constructor (qtdepatas){
        this.qtdepatas=qtdepatas;
    }
}

class Cachorro extends Animal {
    constructor (morde){
        super(4);
        this.morde=morde;
    }
    latir(){
        console.log("Auuuuuu!");
    }
}


let pug=new Cachorro(false);
console.log(pug);
pug.latir();