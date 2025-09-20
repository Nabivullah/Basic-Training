import React, {useRef, useState} from "react";
// import PropTypes from 'prop-types';


// const suggestionMaster=[
//     "Laptop",
//     "mobile",
//     "phone"
// ];

// export default function UseEffectComponent(){
//     const [reccomendation,setRecommendation]=useState([suggestionMaster])

//     UseEffect(()=>{
//         console.log("inside useEffect")
//     }, []
//     );

//     cosnt [search,setSearch]=useState("");


//     return(
//         <div>
//             <input value={search} onChange={(e)=>setSearch(e.target.value)}></input>
//             {   
//                 reccomendation.map((element)=><div>(element)</div>)
//             }
//         </div>
//     )
// }

// export default function UseRefComponent(){

//     const ref= useRef(null);
//     const buttonHandler=()=>{
//         ref.current.focus();}
//     return(
//     <>
//     <div>
//         <input ref={ref}/>
//         <button onClick={buttonHandler}>focus</button>
//     </div>
//     </>
//     )
// }

export default function ParentComponent(){
    const [count,set_count] =useState(0);

    const increment=()=>{
        set_count(p=>p+1);
    }
    const decrement=()=>{
        set_count(p=>p-1);
    }
    return(
        <div>
        welcome to the parent component
        <Sibling1 count={count}/>
        <Sibling2  increment={increment} decrement={decrement}/>
        </div>
    )
}


function Sibling1({count}){
    return(
        <div>
            {count}
        </div>
    )
}

function Sibling2({increment,decrement}){
    return(
        <>
        <button onClick={increment}>increment</button>
        <button onClick={decrement}>decrement</button>
        </>
    )
}