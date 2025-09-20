import React, { useState } from 'react'

function LoginComponent(){

    const [username,setUsername]=useState("")
    const [password,setPassword]=useState("")



    const OnLoginHandler= () =>{
        // alert("login Button Clicked")
        if(username!=="username"){
            alert("invalid username")
            return;
        }
        if(password!=="password"){
            alert("invalid password")
            return;
        }
        alert("login successful")
    }


    return(
        // <div>
        //     <input type='text' value={username} placeholder="enter your username" onChange={(e)=>setUsername(e.target.value)}/>
            
            
        //     <input type='text' value={password} placeholder="enter your password" onChange={(e)=>setPassword(e.target.value)}/>


        //     <button onClick={OnLoginHandler}>
        //         Login
        //     </button>


        // </div>


        // the above code is without using the inbuilt form tag to create a form


        <form>
            <input type='text' placeholder="enter your username"/>
            <input type='password' placeholder="enter your password"/>

            <button type='submit'>submit</button>
            <button type='reset'>reset</button>
             
        </form>
    )
}

export default LoginComponent
