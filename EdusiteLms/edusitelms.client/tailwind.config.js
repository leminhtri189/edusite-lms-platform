/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{html,ts}", 
  ],
  theme: {
    extend: {
      colors: {
        primary: '#1D4ED8',
        dark_grey: '#1F2937',
      },
    },
  },
  plugins: [],
}
