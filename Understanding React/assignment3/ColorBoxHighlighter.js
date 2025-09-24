import React, { useEffect, useRef } from 'react'

export default function ColorBoxHighlighter() {


    const [currentHighlight, setCurrentHighlight] = React.useState(0);

    const BoxColors=["red","green","blue"];

    const boxRefs = [useRef(null), useRef(null), useRef(null)];

    useEffect(() => {
    boxRefs.forEach((ref, index) => {
        if (ref.current) {
            ref.current.style.border = index === currentHighlight ? '30px solid yellow' : 'none';
        }
    });
}, [currentHighlight]);

    function shiftColor(){
        setCurrentHighlight((currentHighlight + 1) % BoxColors.length);
    }

  return (
    <div>
            <div style={{ display: 'flex', flexDirection: 'row', alignItems: 'center', width: '100%' }}>
                {BoxColors.map((color, idx) => (
                    <div
                        key={color}
                        ref={boxRefs[idx]}
                        style={{
                            backgroundColor: color,
                            width: 500,
                            height: 500,
                            margin: 8,
                            textAlign: 'center',
                            borderRadius: '5%',
                            display: 'flex',
                            alignItems: 'center',
                            justifyContent: 'center'
                        }}
                    >
                        <h1 style={{ color: 'white' }}>{color.charAt(0).toUpperCase() + color.slice(1)}</h1>
                    </div>
                ))}
            </div>
            <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', width: '100%', marginTop: 16 }}>
                <button onClick={shiftColor}>Highlight next box</button>
            </div>
        </div>
  )
}
