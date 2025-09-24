import React, { useState, useMemo, useCallback } from 'react';

export default function NumberListAnalyser() {
    const [input, setInput] = useState('');
    const [numbers, setNumbers] = useState([]);


    const addNumber = () => {
        const num = Number(input);
        if (!isNaN(num) && input.trim() !== '') {
            setNumbers([...numbers, num]);
            setInput('');
        }
    };

    const removeNumber = useCallback(
        (idx) => {
            setNumbers(numbers => numbers.filter((_, i) => i !== idx));
        },
        []
    );


    const { sum, max } = useMemo(() => {
        const sum = numbers.reduce((acc, n) => acc + n, 0);
        const max = numbers.length > 0 ? Math.max(...numbers) : null;
        return { sum, max };
    }, [numbers]);


    return (
        
        <div style={{ maxWidth: 400, margin: 'auto' }}>
            <h2>Number List Analyzer</h2>
            <input
                type="number"
                value={input}
                onChange={e => setInput(e.target.value)}
                placeholder="Enter a number"
            />
            <button onClick={addNumber} style={{ marginLeft: 8 }}>Add</button>
            <ul>
                {numbers.map((num, idx) => (
                    <li key={idx} style={{ margin: '8px 0' }}>
                        {num}
                        <button
                            style={{ marginLeft: 12 }}
                            onClick={() => removeNumber(idx)}
                        >
                            Remove
                        </button>
                    </li>
                ))}
            </ul>
            <div>
                <strong>Sum:</strong> {sum}
            </div>
            <div>
                <strong>Largest:</strong> {max !== null ? max : 'N/A'}
            </div>
        </div>
    );
}