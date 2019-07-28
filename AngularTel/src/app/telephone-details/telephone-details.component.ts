import { Component, OnInit } from '@angular/core';
import { Telephone } from '../models/telephone';
import { TelephoneService } from '../services/telephone.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-telephone-details',
  templateUrl: './telephone-details.component.html',
  styleUrls: ['./telephone-details.component.css']
})
export class TelephoneDetailsComponent implements OnInit {

  private sub: any;
  telephone: Telephone;

  constructor(
    private telephoneService: TelephoneService,
    private route: ActivatedRoute,
  ) {}

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.telephoneService
        .getTelephone(params.id)
        .subscribe(data => (this.telephone = data));
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
