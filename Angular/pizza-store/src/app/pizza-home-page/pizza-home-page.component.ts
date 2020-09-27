import { Component, OnInit } from '@angular/core';
import { Pizza } from '../Models/pizza';
import { PizzaService } from '../services/pizza-service';

@Component({
  selector: 'app-pizza-home-page',
  templateUrl: './pizza-home-page.component.html',
  styleUrls: ['./pizza-home-page.component.css']
})
export class PizzaHomePageComponent implements OnInit {

  constructor(private pizzaService: PizzaService) { }
  pizzas: Pizza;
  ngOnInit() {
    this.showPizza();
    
    
  }
  showPizza() {
    this.pizzaService.getPizza()
      .subscribe(data => { 
        console.log(data);
        this.pizzas = data;
      });
  }
}
