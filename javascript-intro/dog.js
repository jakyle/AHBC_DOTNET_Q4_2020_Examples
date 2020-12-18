class Animal {
    name; 
    age;

    constructor(name, age) {
        this.name = name; 
        this.age = age;
    }
}

class Dog extends Animal {
    breed;
    constructor(name, age, breed) {
        super(name, age);
        this.breed = breed;
    }

    bark() {
        return "bark bark!";
    }
}


const coco = new Dog("Coco", 0);  
console.log(coco.name, coco.age); 
console.log(coco.bark());