// data types
let isTrue = true; // boolean: true or false
let age = 32; // number: 11, 13.23 
let name = "James";  // string:, no 'char', only strings
let noReference = null;  // null:  you have a declared variable, but it points to NOTHING, ie null
let notDefined = undefined; // undefined: a variable does not even exist, that variable is NOT DEFINED


// operators 
let num = 2; 
num = num + 2; 
num += 2;
num++;

let stringAge = "32";


if (age === stringAge) {
    console.log("what do you want to drink!");
} else {
    console.log("get lost kid!");
}

// functions 

// int AddTwoNumbers(int x, int y ) {}

function addTwoNumbers(x, y) {
    return x + y;
}

let result = addTwoNumbers(1, 2);
let resultTwo = addTwoNumbers(3, 4);

console.log(resultTwo);  


let condition = false;
// loops 
// for loop
for (let i = 0; condition; i++) {
    const element = array[i];
}

// while loop
while (condition) {
    break;
}

do {
    // continue
} while (condition);

// array, an array in javascript, is a List<T>, in C#, Arrays are Dynamic in size, they change
const names = [ "Theresa", "Mike", "Jason" ]; 
let theresa = names[0];

names[2] = "James";

names.push("Jason");

// object in javascript 
let dog = {
    name: "Coco",
    age: 1
};

console.log(dog.name, dog.age);



// for of loop
for (let name of names) {
    console.log(name);
}


// c,all back function, passing in a FUNCTION as a PARAMETER to a FUNCTION
function initialFunction(supDudeImAFunction) {
    console.log("I live in the initial function call");
    supDudeImAFunction();
}

function callBackFunction() {
    console.log("I live in the call back function");
}

const variableFunction = function() {
    console.log("I'm also a function");
}


function addTwoNumsForReal(x, y){
    return x + y;
}

addTwoNumsForReal(1, 2);

initialFunction(variableFunction);


// arrow functions
function firstFunction(fn) {
    for(let i = 1; i <= 3; i++) {
        fn(i);
    }
}


function logI(i) {
    console.log(`I've been called this many times: ${i}`)
}

firstFunction( (i) => {
    console.log(`I've been called this many times: ${i}`)
})





// wtf.. functional programming
const addTwo = x => x + 2;
const multiplyTwo = x => x * 2;
const squared = x => x * x;

const answerOne = squared(multiplyTwo(addTwo(2)));

const pipe = (...fns) => x => fns.reduce((y, f) => f(y), x);

const mathsComposed = pipe(
    addTwo, 
    multiplyTwo, 
    squared
);

const answerTwo = mathsComposed(2);
console.log(answerOne, answerTwo);





// DOM ( Document Object Model )

console.log(document);




const pressMeBtn = document.getElementById("pressMe");
pressMeBtn.addEventListener("click", (event) => {
    alert("Hey, you did the thing... you clicked me lol ^_^");
})


const changeTextBtn = document.getElementById("changeTextBtn");

changeTextBtn.addEventListener("click", (event) => {
    const p = document.getElementById("hello");
    p.innerText = "Hey guys, I no longer say Hello class!";
});

 


let number = 0;
const addLIBtn = document.getElementById("addLIBtn");

addLIBtn.addEventListener("click", (e) => {
    const list = document.getElementById("list"); 
    
    const li = document.createElement("li");
    li.innerText = number;
    number++;

    list.appendChild(li);
})


const userInput = prompt("Hey, enter your name please!!!");
alert(userInput);





// function myAddEventListener(eventName, fn) {

//     // some logic to find event pased on event nam

//     if (eventName === "click") {
//         const event = new Event();

//         fn(event);
//     }
// } 