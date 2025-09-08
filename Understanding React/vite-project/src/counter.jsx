export function Counter(){
    const hello = ({name}) => <h1>Hello, {name}</h1>;


    let count =0;
    const increment =() =>{
        count++;
        document.getElementById('c1').innerText=count;
    }

    const decrement =() =>{
        count--;
        document.getElementById('c1').innerText=count;
    }

    const reset = () =>{
        count=0;
        document.getElementById('c1').innerText=count;
    }

    return(<div>
        {/* <hello>Adi</hello> */}
        <h1 id="c1">0</h1>
        <button onClick={increment}>INC</button>
        <button onClick={reset}>Reset</button>
        <button onClick={decrement}>DEC</button>
        </div> 
    )
}

// export default counter; 


console.log(x);
var x =5

if(true){
    var a=1;
    
    const c=3;
}
 let b=2;
if(true){
    console.log(b);
}

console.log(a);

// javascript considers all statements after an arrow as a return statement ,more readable this way i.e, reduses the memory and size that a return functio takes 

// use curly braces if there are more than one return statemnt after an arrow 

const add=(a,b) => a+b;


// object destructuring- Extracting props 
// const props={name:xyz info:"abc"}

//example:

function greeting({name='Guest',age}){
    return <p>{name} is {age} years old </p>;
}


const user={
    name: "abc",
    age:"22",
    info:{
        "city":"Kolkata",
        "state":"West bengal"
    }
    
}

const {name:username}=user;
console.log(username);

// const{name: Username = 'Aron' ,info : {city} = {}}=user;
// // const username =user.name;
// // const info = user.info.city;
// console.log(user);

//array destructuring- useState 
// example: let a=1.b=2; [a,b]=[b,a]; -> this is the reversal, a=2 and b=1 now 


//spread operator '...' -> creates shallow copy of objects and arrays without mutating the orignal 

const prev={name:'A' , Age : 20};

const next= {...prev, Age :21};

console.log(next);





