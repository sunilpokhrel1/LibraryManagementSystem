


$(function () {
    var list = [];
    //attach the a function to the click event of the "Add Box Attribute button that will add a new row
    $('#add').click(function () {

        if ($('#BookId').val() != "" && $('#BookName').val() != "" && $('#IssueDate').val() != "" ) {
            
            //var S3 = ($('#BookId').val());
            //list.push(S3);

           

            var IssueItem = {
               BookID: ($('#BookId').val()),
                BookName: ($('#BookName').val()),
                IssueDate: ($('#IssueDate').val())
            //   // Rate: parseFloat($('.rate', this).val())
            }
            
            list.push(IssueItem);
           
            //clone the template row, and all events attached to the row and everything in it

            var $newRow = $('#mainrow').clone(true).removeAttr('id');
            $('.Id', $newRow).val($('#BookId').val());
            $('.book', $newRow).val($('#BookName').val());
            $('.date', $newRow).val($('#IssueDate').val());
           /* document.getElementById('#BookId').value = list[0].BookID;*/

            //remove id attribute from new clone row
            $('#BookId,#BookName,#IssueDate', $newRow).removeAttr('id');

            //$('span.error', $newRow).remove();

            //append clone row
            //$('#orderdetailsItems').append($newRow);
            //clear selected data
            $('#BookId').val('');
            $('#BookName').val('');
            $('#IssueDate').val('');

            


            //add the cloned row to the table immediately before the last row
            $('#maintable tr:last').before($newRow);

            //to prevent the default behavior of submitting the form
            return false;
        }
        else {
            alert("Enter All Field Correctly");
        }
    });

    


    $('#delete').click(function () {

            //find the closest parent row and remove it
            $(this).closest('tr').remove();
        });
    $('#submit').click(function () {

        debugger
        var data = {
            
            StudentId: $('#StudentId').val().trim(),
            StudentName: $('#StudentName').val().trim(),
      
            IssueDetails: list
          

        }

        $.ajax({
            type: 'POST',
            url: '/IssueMaster/IssueBook',
            data: JSON.stringify(data),
           
            contentType: 'application/json',
            success: function (data) {
                if (data.status) {
                    alert('Successfully saved');
                    //here we will clear the form
                    list = [];
                    data = [];
                    debugger
                    $('#StudentId,#StudentName').val('');
                    $('#IssueDetails').empty();
                    debugger
                }
                else {
                    alert('Error');
                }
                $('#submit').text('Save');
            },
            error: function (error) {
                console.log(error);
                $('#submit').text('Save');
            }
        });


        debugger

        debugger
    });
        

  

    //finally, add an initial row by simulating the "Add Box Attribute" click
//    $('#add').click();
});


//$('#submit').click(function () {
   
//    var list = [];

//            var IssueItem = {
//                BookID: $('select.product', this).val(),
//                BookName: $('select.product', this).val(),
//                IssueDate: parseInt($('.quantity', this).val()),
//                Rate: parseFloat($('.rate', this).val())
//            }
//                 list.push(IssueItem);
//        }
//    })



    











////$(document).ready(function () {
////    //Add button click event
////    $('#add').click(function () {
////        debugger
////        //validation and add order items
////        //var isAllValid = true;
////        //if ($('#BookId').val() == "0") {
////        //    isAllValid = false;
////        //    $('#BookId').siblings('span.error').css('visibility', 'visible');
////        //}
////        //else {
////        //    $('#BookId').siblings('span.error').css('visibility', 'hidden');
////        //}

////        //if ($('#BookName').val() == "0") {
////        //    isAllValid = false;
////        //    $('#BookName').siblings('span.error').css('visibility', 'visible');
////        //}
////        //else {
////        //    $('#BookName').siblings('span.error').css('visibility', 'hidden');
////        //}

        
////        /*if (isAllValid)*/
////            var $newRow = $('#mainrow').clone().removeAttr('id');
////            $('.Id', $newRow).val($('#BookId').val());
////            $('.Name', $newRow).val($('#BookName').val());
////            $('.Date', $newRow).val($('#IssueDate').val());

////            //Replace add button with remove button
////            $('#add', $newRow).addClass('remove').val('Remove').removeClass('btn-success').addClass('btn-danger');

////            //remove id attribute from new clone row
////            $('#BookId,#BookName', $newRow).removeAttr('id');
////            $('span.error', $newRow).remove();
////            //append clone row
////            //$('#orderdetailsItems').append($newRow);

////            //clear select data
////            $('#BookId,#BookName,#IssueDate').val('0');
////            //$('#quantity,#rate').val('');
////            //$('#orderItemError').empty();
        

////    })

////    //remove button click event
////    $('#orderdetailsItems').on('click', '.remove', function () {
////        $(this).parents('tr').remove();
////    });

////    $('#submit').click(function () {
////       // var isAllValid = true;

////        //validate order items
////        $('#orderItemError').text('');
////        var list = [];
////        var errorItemCount = 0;
////        $('#orderdetailsItems tbody tr').each(function (index, ele) {
////            if (
////                $('select.product', this).val() == "0" ||
////                (parseInt($('.quantity', this).val()) || 0) == 0 ||
////                $('.rate', this).val() == "" ||
////                isNaN($('.rate', this).val())
////            ) {
////                errorItemCount++;
////                $(this).addClass('error');
////            } else {
////                var orderItem = {
////                    ProductID: $('select.product', this).val(),
////                    Quantity: parseInt($('.quantity', this).val()),
////                    Rate: parseFloat($('.rate', this).val())
////                }
////                list.push(orderItem);
////            }
////        })

////        if (errorItemCount > 0) {
////            $('#orderItemError').text(errorItemCount + " invalid entry in order item list.");
////            isAllValid = false;
////        }

////        if (list.length == 0) {
////            $('#orderItemError').text('At least 1 order item required.');
////            isAllValid = false;
////        }

////        if ($('#orderNo').val().trim() == '') {
////            $('#orderNo').siblings('span.error').css('visibility', 'visible');
////            isAllValid = false;
////        }
////        else {
////            $('#orderNo').siblings('span.error').css('visibility', 'hidden');
////        }

////        if ($('#orderDate').val().trim() == '') {
////            $('#orderDate').siblings('span.error').css('visibility', 'visible');
////            isAllValid = false;
////        }
////        else {
////            $('#orderDate').siblings('span.error').css('visibility', 'hidden');
////        }

////        if (isAllValid) {
////            var data = {
////                OrderNo: $('#orderNo').val().trim(),
////                OrderDateString: $('#orderDate').val().trim(),
////                Description: $('#description').val().trim(),
////                OrderDetails: list
////            }

////            $(this).val('Please wait...');

////            $.ajax({
////                type: 'POST',
////                url: '/home/save',
////                data: JSON.stringify(data),
////                contentType: 'application/json',
////                success: function (data) {
////                    if (data.status) {
////                        alert('Successfully saved');
////                        //here we will clear the form
////                        list = [];
////                        $('#orderNo,#orderDate,#description').val('');
////                        $('#orderdetailsItems').empty();
////                    }
////                    else {
////                        alert('Error');
////                    }
////                    $('#submit').val('Save');
////                },
////                error: function (error) {
////                    console.log(error);
////                    $('#submit').val('Save');
////                }
////            });
////        }

////    });

////});

