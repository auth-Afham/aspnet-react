// src/components/Users.js
import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import axios from 'axios';

const Users = () => {
  const dispatch = useDispatch();
  const users = useSelector(state => state.users);

  useEffect(() => {
    axios.get('http://localhost:5000/api/user')
      .then(response => {
        dispatch({ type: 'SET_USERS', payload: response.data });
      })
      .catch(error => {
        console.error('There was an error fetching the users!', error);
      });
  }, [dispatch]);

  return (
    <div>
      <h1>Users</h1>
      <ul>
        {users.map(user => (
          <li key={user.id}>{user.name}</li>
        ))}
      </ul>
    </div>
  );
};

export default Users;
