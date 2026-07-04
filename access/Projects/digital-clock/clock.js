// 1. hour12 variable ကို function အပြင်ဘက်မှာ Global အနေနဲ့ အရင်ကြေညာမယ်
let hour12 = true;
let myTime = setInterval(myClock, 1000);

function myClock() {
  let time = document.getElementById("time");
  let date = document.getElementById("date");
  let month = document.getElementById("month");

  let currentTime = new Date();
  let day = currentTime.getDay();
  switch (day) {
    case 0:
      day = "Sunday";
      break;
    case 1:
      day = "Monday";
      break;
    case 2:
      day = "Tuesday";
      break;
    case 3:
      day = "Wednesday";
      break;
    case 4:
      day = "Thursday";
      break; 
    case 5:
      day = "Friday";
      break;
    case 6:
      day = "Saturday";
      break;
    default:
      day = "Other Day";
      break;
  }

 


time.innerHTML = currentTime.toLocaleTimeString(undefined, { hour12: hour12 });
date.innerHTML = `${currentTime.toLocaleDateString()}, ${day}`;
month.innerHTML = currentTime.toLocaleString(undefined, { month: 'long'} );
}


let btn_12 = document.getElementById("btn-12");
let btn_24 = document.getElementById("btn-24");

btn_12.addEventListener("click", () => {
  hour12 = true;
  btn_12.classList.add("active");
  btn_24.classList.remove("active");
  myClock(); 
});

btn_24.addEventListener("click", () => {
  hour12 = false;
  btn_12.classList.remove("active");
  btn_24.classList.add("active");
  myClock(); 
});
