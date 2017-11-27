# Pallida Orientation Exam Retake

## 1) Green Fox Fashion Web Store

Build a webshop that people can use to order some merchandise from the Greenfox store.

# Main page

![main](assets/main2.png)

- the **frontend** should have
    - a heading with the title of the site
    - dropdown list with all unique name options
    - dropdown list with all unique size options
    - input field to set the quantity of clothes
    - a GET TOTAL button which redirects to the `Summary` page
    - list the clothing items of the database in table

## Backend
- when GET TOTAL button is submitted the backend should
    - summarize the total price based on the quantity that was given in the inputfield and send these information to the `Summary` page

## Endpoints
- you should create these endpoints:

### GET `/warehouse`
- the endpoint should render an HTML displaying the full list of clothes(explained above)

### POST `/warehouse/summary`
- this endpoint should receive all the information of the selected item
- this endpoint should render an other HTML after receiving the data, which should display the extract of the selected item in a table:
  - item name
  - manufacturer
  - category
  - size
  - amount
  - sub-total price of the item (based on nr. of selected item)

### GET `/warehouse/query`
- this endpoint should return all the clothes which has higher/lower/equal price than the given parameter

Example query:

`http://localhost:8080/warehouse/query?price=50&type=lower`

- this should return a json with every cloth where the unit price is lower than 50

```json
{
    "result": "ok",
    "clothes":
    [
        {
            "id": "21",
            "item_name": "Strecth Steamed Pencil Skirt",
            "manufacturer": "Calvin Klein",
            "category": "skirts",
            "size": "s",
            "unit_price": 39.0,
        },
        {
            "id": "24",
            "item_name": "Strecth Steamed Pencil Skirt",
            "manufacturer": "Calvin Klein",
            "category": "skirts",
            "size": "m",
            "unit_price": 39.0,
        },
    ]
}
```

# Summary page

![summary](assets/summarypage.png)

- the **frontend** should have:
  - a heading with the title of the page
  - a link back to the main page
  - the list of selected items with the properties defined above

## 2) Endpoint TESTing
- create 2 endpoint tests all together, you can choose on which endpoint/endpoints

## 3) Question time
  Why would you declare your class as an abstract class?
  Declaring a class as abstract is useful when it is a base class, and its methods should be implemented differently in the future derived classes.
