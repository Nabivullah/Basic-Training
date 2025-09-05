export function Counter(){
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
        <h1 id="c1">0</h1>
        <button onClick={increment}>INC</button>
        <button onClick={reset}>Reset</button>
        <button onClick={decrement}>DEC</button>
        </div> 
    )
}

export default counter; 