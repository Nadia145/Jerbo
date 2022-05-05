<?php  
 $connect = mysqli_connect("localhost", "root", "Jerbo401*", "Jerbo");  
 $query = "SELECT age, count(*) as number FROM infousuarios GROUP BY age";  
 $result = mysqli_query($connect, $query);  
 ?>  

<!DOCTYPE html>  
 <html>  
      <head>  
           <title>graph countries</title>  
           <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>  
           <script type="text/javascript">  
           google.charts.load('current', {'packages':['corechart']});  
           google.charts.setOnLoadCallback(drawChart);  
           function drawChart()  
           {  
                var data = google.visualization.arrayToDataTable([  
                          ['gender', 'Number'],  
                          <?php  
                          while($row = mysqli_fetch_array($result))  
                          {  
                               echo "['".$row["age"]."', ".$row["number"]."],";  
                          }  
                          ?>  
                     ]);  
                var options = {  
                      title: 'age',  
                      //is3D:true,  
                      pieHole: 0.4  
                     };  
                var chart = new google.visualization.BarChart(document.getElementById('mychart'));  
                chart.draw(data, options);  
           }  
           </script>  
      </head>  
      <body>  
           <br /><br />  
           <div style="width:900px;">  
                <h3 align="center">Age</h3>  
                <br />  
                <div id="mychart" style="width: 900px; height: 500px;"></div>  
           </div>  
      </body>  
 </html>  