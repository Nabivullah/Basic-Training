import React, { useState,useEffect } from 'react'

export default function MouseTracker() {

    const [x,setX]=React.useState(0);
    const [y,setY]=React.useState(0);

    useEffect(()=>{
        console.log("useEffect called");
        // window.addEventListener('mousemove',handleMouseMove);

    function handleMouseMove(event){
        setX(event.clientX);
        setY(event.clientY);
    }

      window.addEventListener('mousemove',handleMouseMove)

        return()=>{window.removeEventListener('mousemove',handleMouseMove);
    };   
},[]);

  return (
    <div>
        <h2>Mouse Coordinates</h2>
        <p>X:{x},Y:{y}</p>
      
    </div>
  )
}
