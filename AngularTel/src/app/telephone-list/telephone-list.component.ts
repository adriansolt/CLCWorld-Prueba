import { Component, OnInit } from '@angular/core';
import { TelephoneService } from '../services/telephone.service';
import { Telephone } from '../models/telephone';

@Component({
  selector: 'app-telephone-list',
  templateUrl: './telephone-list.component.html',
  styleUrls: ['./telephone-list.component.css']
})
export class TelephoneListComponent implements OnInit {

  telephones: Telephone[];

  constructor(telephoneService: TelephoneService) {
    telephoneService.getTelephones().subscribe(data => (this.telephones = data));
   }

  ngOnInit() {
  }

}
