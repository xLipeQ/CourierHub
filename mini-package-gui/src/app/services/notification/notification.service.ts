import { Injectable } from '@angular/core';
import { NgToastService, PositionType } from 'ng-angular-popup';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  constructor(
    private toast: NgToastService
  ) { }

  notifySuccess(title: string, message: string, duration: number, pos: PositionType) {
    this.toast.success({
      detail: title,
      summary: message,
      duration: duration,
      position: pos
    });
  }

  notifyWarning(title: string, message: string, duration: number, pos: PositionType) {
    this.toast.warning({
      detail: title,
      summary: message,
      duration: duration,
      position: pos
    });
  }

  notifyError(title: string, message: string, duration: number, pos: PositionType) {
    this.toast.error({
      detail: title,
      summary: message,
      duration: duration,
      position: pos
    });
  }

  notiftyInfo(title: string, message: string, duration: number, pos: PositionType) {
    this.toast.info({
      detail: title,
      summary: message,
      duration: duration,
      position: pos
    });
  }
}
