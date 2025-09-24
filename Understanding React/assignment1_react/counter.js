import React, { useState } from 'react'
import Button from './Button.js';
import MouseTracker from '../assignment2/MouseTracker.js'; 

export default function Counter() {
    const [Count,setCounter]=useState(0);

  function increment(){
    setCounter(Count + 1);
    console.log("Increment Clicked");
  }

  function decrement(){
    setCounter(Count - 1);
        console.log("decrement Clicked");
  }



  return (
    <div>
      {/* <Button label="increment" onClick={increment}/>
      <div>{Count}</div>  
      <Button label="decrement" onClick={decrement}/> */}
      {/* hello world */}
      <MouseTracker/>
    </div>
  )
}
