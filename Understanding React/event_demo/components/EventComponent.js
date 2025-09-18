import react from "react";


const dummyjson={
    
        "firstName":"MYNAME",
        "LastName":"NOTYOURNAME",
        "target":{
            "value":"add"
        }
    
}

function EventComponent(){

    const onChangeHandler=(myobject)=>{
        console.log(myobject.target.value)
    }

    return (
        <>
        
        <h1>Welcome to events </h1>
        
        <button onClick={()=>{console.log("button clicked");}}>click me </button>

        <div style={{background:'red',padding:'50px',textAlign:"center",fontSize:'50px'}}
            onMouseOver={()=>{console.log("the mouse has entered the div")}
        }
        >
            This is a div
        </div>

        <input type="text" onChange={onChangeHandler} ></input>


        </>
    )
}

export default EventComponent;