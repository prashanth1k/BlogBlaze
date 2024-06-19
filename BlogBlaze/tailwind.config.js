/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor, html}"],
  theme: {
    extend: {
      colors: {
        primary: "#FF0000",
        secondary: "#00FF00",
        tertiary: "#0000FF",
      },
      fontFamily: {
        sans: ["Roboto", "Arial", "sans-serif"],
      },
      fontSize: {
        sm: "14px",
        md: "16px",
        lg: "18px",
      },
    },
  },
};
