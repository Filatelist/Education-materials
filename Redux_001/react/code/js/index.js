import React from 'react';
import ReactDOM from "react-dom";
import {Provider} from 'react-redux';
import {createStore} from 'redux';
import allReducers from './reducers'
import WebPage from './components/WebPage';
const store = createStore(allReducers);
ReactDOM.render(
  <WebPage />,
  document.getElementById('fieldToShow')
);
