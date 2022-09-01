import React, { useState, useEffect } from "react";
import {
    Row,
    Col,
    DropdownItem,
    DropdownMenu,
    DropdownToggle,
    UncontrolledDropdown,
    Input,
    Button
  } from "reactstrap";
import book from "./book";
import table from "./table";


export default props => {

    // Sending the request to The DB
    const reserveOrder = async _ => {
          let res = await fetch("https://localhost:5001/api/Reservation", {
            method: "POST",
            headers: {
              "Content-Type": "application/json"
            },
            body: JSON.stringify({
              ...selectOrder,
              description: selectOrder.description
            })
          });
          res = await res.text();
          console.log("Reserved: " + res);
          props.setPage(3);
      };

    // creating the instance of orders
    const [Orders] = useState([
        "Pizza ,Chill chicken- large",
        "Burgar 4",
        "Juice",
        "Milkshake + coke",
        "Full chicken",
        "chiken + pap+ coke-1L",
        "Family Meal",
        "Evening family meal",
        "Dessert"
      ]);

        // User's selections
  const [selectOrder, setSelectOrder] = useState({
    reservationId: 0,
    description: null
  });
  
  // Geting the orders
  const getOrders = _ => {
    let newOrders = [];
    Orders.forEach(orde => {
      newOrders.push(
        <DropdownItem
          key={orde}
          className="booking-dropdown-item"
          onClick={_ => {
            let newSel = {
              ...selectOrder,
              description: {
                ...selectOrder.description
              },
              description: orde
            };
            setSelectOrder(newSel);
          }}
        >
          {orde}
        </DropdownItem>
      );
    });
    return newOrders;
  };



  return (
    <div className="order-container">
      <h1 className="header-form">Would you Like to place some orders at your reservation?</h1><br/><br/>

        <div>
            <h1 className="header-forms">Place your Order here</h1><br/><br/>
        </div>

        <div className="">
            <form className="form">
                     <label 
                        htmlFor="name"
                        className="form-lebel"> table Number </label> <br/>
                        <input 
                        id="table_id"
                        type="text"
                        className="block appearance-none w-full px-3 py-2 border border-gray-300 roundedn-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-gray-200 focus:border-gray-200"
                        /><br/><br/> 

                    <label      
                        htmlFor="order"
                        className="form-lebel"> Type of food & description </label> <br/> 
                      <Col xs="12" sm="3">
                        <UncontrolledDropdown>
                         <DropdownToggle color="none" caret className="booking-dropdown">
                            {selectOrder.description === null ? "Select available orders" : selectOrder.description.toString()}
                         </DropdownToggle>   
                        <DropdownMenu right className="booking-dropdown-menu">
                            {getOrders()};
                        </DropdownMenu>
                        </UncontrolledDropdown>   
                        </Col>    
                        <br/><br/> 
            </form>
        </div>

        <div>
        <Row noGutters className="text-center">
            <Col>
              <Button
                color="none"
                className="book-table-btn"
                onClick={_ => {
                    reserveOrder();
                }}
              >
                Place Order Now
              </Button>
            </Col>
          </Row>
        </div>
    </div>
  );
};
