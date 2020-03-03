function timeToWalk(steps, stepLength, speed) {
    let time = (steps * stepLength) / 1000 / speed;
    time += parseInt(steps * stepLength / 500) / 60;

    function addZero(i) {
        if (i < 10) {
          i = "0" + i;
        }
        return i;
      }

    function timeConvert(timeMins) {
        let hours = parseInt(timeMins);
        let minutes = parseInt(timeMins * 60);
        let seconds =Math.round((((timeMins * 60) - minutes) % 10) * 60);

        console.log(`${addZero(hours)}:${addZero(minutes)}:${addZero(seconds)}`);
    }

    timeConvert(time);
}

timeToWalk(2564, 0.70, 5.5);