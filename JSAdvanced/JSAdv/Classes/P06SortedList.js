class result{
    constructor(){
        this.array=[];
       this.size=0;
    }
    add(element){
        this.array.unshift(element);
        this.size++;
    }
    remove(index){
        this.array.splice(index,1);
        this.size--;
    }
    get(index){
        return this.array[index];
    }
}

// Instantiate and test functionality
let myList = new List();

myList.add(5);
console.log(myList.get(0));
// expect(myList.get(0)).to.equal(5, "Element wasn't added");

myList.add(3);
console.log(myList.get(0));
// expect(myList.get(0)).to.equal(3, "Collection wasn't sorted");

myList.remove(0);
console.log(myList.get(0));
console.log(myList.size);
// expect(myList.get(0)).to.equal(5, "Element wasn't removed");
// expect(myList.size).to.equal(1, "Element wasn't removed");
