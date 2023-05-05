// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




$(document).ready(function() {
    $('select[name="level"]').on('change', function() {
      var form = $(this).closest('form');
      var data = form.serialize();
      $.ajax({
        url: 'CalculateSumLevel',
        type: 'POST',
        data: data,
        success: function(result) {
          $('#totalLevel').text(result);
        }
      });
    });
  });


  
  $(document).ready(function() {
    $('input[name="percent"]').on('input', function() {
      var form = $(this).closest('form');
      var data = form.serialize();
      $.ajax({
        url: 'CalculatePercLevel',
        type: 'POST',
        data: data,
        success: function(result) {
          $('#totalPerc').text(result);
        }
      });
    });
  });
  

  
  const selectElement = document.querySelector('select[name="subject"]');
  const buttonElement = document.getElementById('myButton');
  const resultElement = document.getElementById('result');
  
  selectElement.addEventListener('change', (event) => {
    event.preventDefault();
    const selectedValue = selectElement.value;
    resultElement.textContent = `${selectedValue}`;
  });
  
  buttonElement.addEventListener('click', (event) => {
    event.preventDefault();
    const selectedValue = selectElement.value;
    resultElement.textContent = `${selectedValue}`;
  });

