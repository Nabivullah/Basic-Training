import React, { createContext, useContext, useState } from 'react';

// 1. Create ThemeContext
const ThemeContext = createContext();

// 2. Theme styles
const themes = {
    light: {
        background: '#fff',
        color: '#000'
    },
    dark: {
        background: '#000',
        color: '#fff'
    }
};

// 3. ThemeProvider component
function ThemeProvider({ children }) {
    const [theme, setTheme] = useState('light');
    const toggleTheme = () =>
        setTheme((prev) => (prev === 'light' ? 'dark' : 'light'));

    return (
        <ThemeContext.Provider value={{ theme, toggleTheme }}>
            {children}
        </ThemeContext.Provider>
    );
}

// 4. ThemeSwitcherApp component
function ThemeSwitcherApp() {
    const { theme, toggleTheme } = useContext(ThemeContext);

    const style = {
        minHeight: '100vh',
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        ...themes[theme]
    };

    return (
        <div style={style}>
            <h1>Hello Students!</h1>
            <button onClick={toggleTheme}>Toggle Theme</button>
        </div>
    );
}

// 5. Export App wrapped with ThemeProvider
export default function AppWrapper() {
    return (
        <ThemeProvider>
            <ThemeSwitcherApp />
        </ThemeProvider>
    );
}