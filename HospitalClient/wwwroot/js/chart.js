function setupHomeCharts(myAppointments, hospitalAppointments) {
    var backgroundColor = [
        '#0c6f62',
        '#206860',
        '#34615d',
        '#485b5b',
        '#5c5458',
        '#704d56',
        '#844654',
        '#973f51',
        '#ab384f',
        '#bf314c',
        '#d32b4a',
        '#e72447'
    ]
    var options = {
        maintainAspectRatio: false,
        legend: {
            display: false
        },
        scales: {
            yAxes: [{
                ticks: {
                    fontColor: "white",
                    fontSize: 18,
                    stepSize: 1
                }
            }],
            xAxes: [{
                ticks: {
                    fontColor: "white",
                    fontSize: 14,
                    stepSize: 1
                }
            }]
        }
    };
    // My Appointments
    var ctx = document.getElementById('myAppointments').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: Object.keys(myAppointments),
            datasets: [{
                data: Object.values(myAppointments),
                backgroundColor,
                borderWidth: 1
            }]
        },
        options
    });

    // Hospital Appointments
    var ctx = document.getElementById('hospitalAppointments').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: Object.keys(hospitalAppointments),
            datasets: [{
                data: Object.values(hospitalAppointments),
                backgroundColor,
                borderWidth: 1
            }]
        },
        options
    });
}