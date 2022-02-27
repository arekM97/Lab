

let elementsToCount = document.querySelectorAll('.count_value');
let numOne = 0, numTwo = 0;

elementsToCount.forEach((elem) => {
    if (elem.innerText.includes("True")) numOne++;
    if (elem.innerText.includes("False")) numTwo++;
})
$(document).ready(function () {
    var ctx = $("#chart-line");
    var myLineChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ["Good", "Bad"],
            datasets: [{
                data: [numOne, numTwo],
                backgroundColor: ["rgba(100, 255, 0, 0.5)", "rgba(255, 0, 0, 0.5)"]
            }]
        }
    });
});