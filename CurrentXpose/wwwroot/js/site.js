// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function iniciarGrafico() {
    var ctx = document.getElementById('hitoricoMoradorChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio'],
            datasets: [{
                label: 'Consumo (kWh)',
                data: [50, 70, 45, 60, 80],
                borderColor: '#FDC119',
                backgroundColor: 'transparent',
                pointBackgroundColor: '#FDC119',
                pointRadius: 6
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}

